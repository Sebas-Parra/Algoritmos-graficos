using System;
using System.Collections.Generic;
using System.Drawing;
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
        private const float SF = 20;
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

        public void InitializeData(TextBox txtSide,

                                    PictureBox picCanvas)
        {
            nlado = 0;

            txtSide.Text = "";

            txtSide.Focus();
            picCanvas.Refresh();
        }

        public async Task FloodFillAsync(int x, int y, PictureBox picCanvas, DataGridView dgv)
        {
            this.pic = picCanvas;
            this.tabla = dgv;
            if (lienzo == null)
            {
                MessageBox.Show("Primero dibuja la figura.");
                return;
            }


            Color targetColor = lienzo.GetPixel(x, y);
            await Task.Run(() => FloodFill(x, y, targetColor));
        }

        private void FloodFill(int x, int y, Color targetColor)
        {
            if (x < 0 || y < 0 || x >= lienzo.Width || y >= lienzo.Height)
                return;

            if (lienzo.GetPixel(x, y).ToArgb() != targetColor.ToArgb() ||
                lienzo.GetPixel(x, y).ToArgb() == fillColor.ToArgb())
                return;

            lienzo.SetPixel(x, y, fillColor);

            pic.Invoke((MethodInvoker)(() =>
            {
                pic.Image = lienzo;
                tabla.Rows.Add(ordinal++, x, y);
            }));

            Thread.Sleep(10);


            FloodFill(x, y - 1, targetColor); // Norte
            FloodFill(x + 1, y, targetColor); // Este
            FloodFill(x, y + 1, targetColor); // Sur
            FloodFill(x - 1, y, targetColor); // Oeste
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
