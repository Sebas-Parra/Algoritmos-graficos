using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLies2
{
    public class FiguraRelleno
    {
        private List<PointF> listaPuntos;
        private int nlado;
        private Graphics mGraph;
        private const float SF = 10;
        private Pen mPen;

        private Bitmap lienzo;
        private Color fillColor = Color.Red;
        private PictureBox pic;
        private DataGridView tabla;
        private int ordinal = 1;

        public FiguraRelleno()
        {
            listaPuntos = new List<PointF>();
        }

        // Lee el número de lados desde un TextBox y valida
        public void ReadData(TextBox txtLado)
        {
            if (!int.TryParse(txtLado.Text, out nlado) || nlado < 3)
            {
                MessageBox.Show("Ingrese un número entero mayor o igual a 3", "Error");
                txtLado.Focus();
                txtLado.Clear();
            }
        }

        public void InitializeData(TextBox txtSide, PictureBox picCanvas)
        {
            nlado = 0;
            txtSide.Text = "";
            txtSide.Focus();

            listaPuntos.Clear();

            lienzo?.Dispose();
            lienzo = new Bitmap(picCanvas.Width, picCanvas.Height);

            using (Graphics g = Graphics.FromImage(lienzo))
            {
                g.Clear(Color.White);
            }

            picCanvas.Image = lienzo; 
            picCanvas.Refresh(); 
        }


        public async Task FloodFillAsync(int x, int y, PictureBox picCanvas)
        {
            if (listaPuntos.Count == 0) return;

            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(listaPuntos.ToArray());
            if (!path.IsVisible(x, y)) return;

            this.pic = picCanvas;

            // ⚠️ Copiar el lienzo localmente
            Bitmap lienzoLocal = lienzo;
            if (lienzoLocal == null)
            {
                MessageBox.Show("Primero dibuja la figura.");
                return;
            }

            Color targetColor;
            lock (this)
            {
                targetColor = lienzoLocal.GetPixel(x, y);
            }

            await Task.Run(() => FloodFillIterativo(x, y, targetColor, lienzoLocal));
        }


        private void FloodFillIterativo(int x, int y, Color targetColor, Bitmap lienzoLocal)
        {
            if (targetColor.ToArgb() == fillColor.ToArgb())
                return;

            Stack<Point> stack = new Stack<Point>();
            stack.Push(new Point(x, y));

            while (stack.Count > 0)
            {
                Point p = stack.Pop();
                int px = p.X;
                int py = p.Y;

                if (px < 0 || py < 0 || px >= lienzoLocal.Width || py >= lienzoLocal.Height)
                    continue;

                Color currentColor = lienzoLocal.GetPixel(px, py);
                if (currentColor.ToArgb() != targetColor.ToArgb() || currentColor.ToArgb() == fillColor.ToArgb())
                    continue;

                lienzoLocal.SetPixel(px, py, fillColor);

                // Opcional: Actualiza la imagen en el PictureBox si quieres ver el proceso
                // pic.Invoke((MethodInvoker)(() => { pic.Image = lienzoLocal; }));
                // Thread.Sleep(1);

                stack.Push(new Point(px, py - 1)); // Norte
                stack.Push(new Point(px + 1, py)); // Este
                stack.Push(new Point(px, py + 1)); // Sur
                stack.Push(new Point(px - 1, py)); // Oeste
            }

            // Actualiza la imagen al final
            pic.Invoke((MethodInvoker)(() => { pic.Image = lienzoLocal; }));
        }


        public void ConfigurarTabla(DataGridView tabla)
        {
            tabla.Columns.Clear();
            tabla.Columns.Add("Ordinal", "Ordinal");
            tabla.Columns.Add("X", "X");
            tabla.Columns.Add("Y", "Y");
        }

        public float CalcularAngulo()
        {
            float angulo = 360 / nlado;
            return angulo;
        }


        public void PlotShape(PictureBox picCanvas)
        {
            int width = picCanvas.Width;
            int height = picCanvas.Height;
            lienzo = new Bitmap(width, height);
            listaPuntos.Clear(); // Limpia puntos anteriores

            int numLados = nlado;
            float anguloGrados = 360f / numLados;
            float anguloRadianes;
            float radio = 5 * SF;

            int centerX = width / 2;
            int centerY = height / 2;

            using (Graphics g = Graphics.FromImage(lienzo)) 
            {
                g.Clear(Color.White);
                mPen = new Pen(Color.Blue, 3);

                for (int i = 0; i < numLados; i++)
                {
                    anguloRadianes = (float)(Math.PI / 180 * (anguloGrados * i));
                    float x = centerX + (float)(radio * Math.Cos(anguloRadianes));
                    float y = centerY + (float)(radio * Math.Sin(anguloRadianes));
                    listaPuntos.Add(new PointF(x, y));
                }

                for (int j = 0; j < numLados; j++)
                {
                    PointF puntoInicio = listaPuntos[j];
                    PointF puntoFin = listaPuntos[(j + 1) % numLados];
                    g.DrawLine(mPen, puntoInicio, puntoFin);
                    System.Threading.Thread.Sleep(70);
                    Application.DoEvents();
                }
            }

            picCanvas.Image = lienzo; // Mostrar la imagen en pantalla
        }

    }
}
