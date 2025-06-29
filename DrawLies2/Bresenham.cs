using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace DrawLies2
{
    public class Bresenham
    {
        private int xi;
        private int yi;
        private int x;
        private int y;
        private Graphics mGraph;
        private Pen mPen;

        public Bresenham()
        {
            this.xi = 0;
            this.yi = 0;
            this.x = 0;
            this.y = 0;
        }

        public bool ReadData(TextBox txtPuntoxi, TextBox txtPuntoyi, TextBox txtPuntox, TextBox txtPuntoy)
        {
            if (string.IsNullOrWhiteSpace(txtPuntoxi.Text) ||
                string.IsNullOrWhiteSpace(txtPuntoyi.Text) ||
                string.IsNullOrWhiteSpace(txtPuntox.Text) ||
                string.IsNullOrWhiteSpace(txtPuntoy.Text))
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtPuntoxi.Text, out xi) || xi < 0 ||
                !int.TryParse(txtPuntoyi.Text, out yi) || yi < 0 ||
                !int.TryParse(txtPuntox.Text, out x) || x < 0 ||
                !int.TryParse(txtPuntoy.Text, out y) || y < 0)
            {
                MessageBox.Show("Los valores deben ser números enteros positivos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (xi == x && yi == y)
            {
                MessageBox.Show("El punto inicial y final no pueden ser iguales.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }


        public void InitializeData(TextBox txtPuntoxi, TextBox txtPuntoyi, TextBox txtPuntox, TextBox txtPuntoy, PictureBox picCanvas, DataGridView tabla)
        {
            xi = yi = x = y = 0;

            txtPuntoxi.Text = ""; txtPuntox.Text = "";
            txtPuntoyi.Text = ""; txtPuntoy.Text = "";

            txtPuntoxi.Focus();
            picCanvas.Refresh();


            tabla.Rows.Clear();
            tabla.Columns.Clear();
            tabla.Columns.Add("Ordinal", "Ordinal");
            tabla.Columns.Add("X", "X");
            tabla.Columns.Add("Y", "Y");
        }

        public void ConfigurarTabla(DataGridView tabla)
        {
            tabla.Columns.Clear();
            tabla.Columns.Add("Ordinal", "Ordinal");
            tabla.Columns.Add("X", "X");
            tabla.Columns.Add("Y", "Y");
        }

        public void PlotShape(PictureBox picCanvas, DataGridView tabla)
        {
            mGraph = picCanvas.CreateGraphics();
            mGraph.Clear(Color.White); // Limpiar canvas al inicio
            mPen = new Pen(Color.Red, 1);

            tabla.Rows.Clear();

            int dx = x - xi;
            int dy = y - yi;

            int x0 = xi;
            int y0 = yi;
            int x1 = x;
            int y1 = y;

            int absDx = Math.Abs(dx);
            int absDy = Math.Abs(dy);

            int sx = dx >= 0 ? 1 : -1;
            int sy = dy >= 0 ? 1 : -1;

            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;

            int px = x0;
            int py = y0;

           
            if (absDx > absDy)
            {
                int p = 2 * absDy - absDx;
                for (int i = 0; i <= absDx; i++)
                {
                    int xCanvas = centerX + px;
                    int yCanvas = centerY - py;
                    mGraph.DrawRectangle(mPen, xCanvas, yCanvas, 1, 1);

                    tabla.Rows.Add(absDx, px, py);

                    Thread.Sleep(60);
                    Application.DoEvents();


                    px += sx;
                    if (p < 0)
                    {
                        p += 2 * absDy;
                    }
                    else
                    {
                        py += sy;
                        p += 2 * absDy - 2 * absDx;
                    }
                }
            }
            else
            {
                int p = 2 * absDx - absDy;
                for (int i = 0; i <= absDy; i++)
                {
                    int xCanvas = centerX + px;
                    int yCanvas = centerY - py;
                    mGraph.DrawRectangle(mPen, xCanvas, yCanvas, 1, 1);

                    tabla.Rows.Add(absDy, px, py);

                    Thread.Sleep(60);
                    Application.DoEvents();


                    py += sy;
                    if (p < 0)
                    {
                        p += 2 * absDx;
                    }
                    else
                    {
                        px += sx;
                        p += 2 * absDx - 2 * absDy;
                    }
                }
            }

            Pen ejePen = new Pen(Color.LightGray, 1);
            mGraph.DrawLine(ejePen, 0, centerY, picCanvas.Width, centerY);
            mGraph.DrawLine(ejePen, centerX, 0, centerX, picCanvas.Height);
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }

    }
}
