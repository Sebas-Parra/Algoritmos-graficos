using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLies2
{
    public class Scanline
    {
        private List<PointF> listaPuntos;
        private int nlado;
        private const float SF = 20;
        private Pen mPen;
        private Bitmap lienzo;
        private Color fillColor = Color.Red;
        private PictureBox pic;

        public Scanline()
        {
            listaPuntos = new List<PointF>();
        }

        public bool ReadData(TextBox txtLado)
        {
            if (string.IsNullOrWhiteSpace(txtLado.Text))
            {
                MessageBox.Show("Ingrese el número de lados.", "Campo vacío");
                txtLado.Focus();
                return false;
            }

            bool esNumero = int.TryParse(txtLado.Text, out nlado);

            if (!esNumero)
            {
                MessageBox.Show("Ingrese solo números enteros positivos.", "Error de entrada");
                txtLado.Clear();
                txtLado.Focus();
                return false;
            }

            if (nlado < 3)
            {
                MessageBox.Show("El número mínimo de lados debe ser 3.", "Entrada inválida");
                txtLado.Clear();
                txtLado.Focus();
                return false;
            }

            return true;
        }


        public void InitializeData(TextBox txtSide, PictureBox picCanvas)
        {
            nlado = 0;
            txtSide.Text = "";
            txtSide.Focus();
            picCanvas.Image = null;
        }

        public void PlotShape(PictureBox picCanvas)
        {
            int width = picCanvas.Width;
            int height = picCanvas.Height;
            lienzo = new Bitmap(width, height);
            listaPuntos.Clear();

            float anguloGrados = 360f / nlado;
            float radio = 5 * SF;
            int centerX = width / 2;
            int centerY = height / 2;

            using (Graphics g = Graphics.FromImage(lienzo))
            {
                g.Clear(Color.White);
                mPen = new Pen(Color.Blue, 3);

                for (int i = 0; i < nlado; i++)
                {
                    float rad = (float)(Math.PI / 180 * (anguloGrados * i));
                    float x = centerX + (float)(radio * Math.Cos(rad));
                    float y = centerY + (float)(radio * Math.Sin(rad));
                    listaPuntos.Add(new PointF(x, y));
                }

                for (int j = 0; j < nlado; j++)
                {
                    PointF pInicio = listaPuntos[j];
                    PointF pFin = listaPuntos[(j + 1) % nlado];
                    g.DrawLine(mPen, pInicio, pFin);
                }
            }

            picCanvas.Image = lienzo;
        }

        public async Task ScanlineFillAsync(int x, int y, PictureBox picCanvas)
        {
            this.pic = picCanvas;
            if (lienzo == null)
            {
                MessageBox.Show("Primero dibuja la figura.");
                return;
            }

            Color targetColor = lienzo.GetPixel(x, y);
            await Task.Run(() => ScanlineFill(x, y, targetColor));
            picCanvas.Image = lienzo;
        }

        private void ScanlineFill(int x, int y, Color targetColor)
        {
            Stack<Point> stack = new Stack<Point>();
            stack.Push(new Point(x, y));

            while (stack.Count > 0)
            {
                Point p = stack.Pop();
                int px = p.X;
                int py = p.Y;

                while (px >= 0 && lienzo.GetPixel(px, py).ToArgb() == targetColor.ToArgb())
                    px--;
                px++;

                bool spanArriba = false;
                bool spanAbajo = false;

                while (px < lienzo.Width && lienzo.GetPixel(px, py).ToArgb() == targetColor.ToArgb())
                {
                    lienzo.SetPixel(px, py, fillColor);

                    if (py > 0)
                    {
                        Color arriba = lienzo.GetPixel(px, py - 1);
                        if (arriba.ToArgb() == targetColor.ToArgb())
                        {
                            if (!spanArriba)
                            {
                                stack.Push(new Point(px, py - 1));
                                spanArriba = true;
                            }
                        }
                        else spanArriba = false;
                    }

                    if (py < lienzo.Height - 1)
                    {
                        Color abajo = lienzo.GetPixel(px, py + 1);
                        if (abajo.ToArgb() == targetColor.ToArgb())
                        {
                            if (!spanAbajo)
                            {
                                stack.Push(new Point(px, py + 1));
                                spanAbajo = true;
                            }
                        }
                        else spanAbajo = false;
                    }

                    px++;
                }
            }
        }
    }
}
