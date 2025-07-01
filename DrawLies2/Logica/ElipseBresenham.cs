using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLies2
{
    public class ElipseBresenham
    {

        private int xc;
        private int yc;
        private int rx;
        private int ry;
        private Graphics mGraph;
        private Pen mPen;

        public ElipseBresenham()
        {
            xc = yc = rx = ry = 0;
        }

        public void ReadData(TextBox txtCentroX, TextBox txtCentroY, TextBox txtRadioX, TextBox txtRadioY)
        {
            if (string.IsNullOrWhiteSpace(txtCentroX.Text) || string.IsNullOrWhiteSpace(txtCentroY.Text) ||
                string.IsNullOrWhiteSpace(txtRadioX.Text) || string.IsNullOrWhiteSpace(txtRadioY.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos.", "Error de entrada");
                return;
            }

            bool validXc = int.TryParse(txtCentroX.Text, out xc);
            bool validYc = int.TryParse(txtCentroY.Text, out yc);
            bool validRx = int.TryParse(txtRadioX.Text, out rx);
            bool validRy = int.TryParse(txtRadioY.Text, out ry);

            if (!validXc || !validYc || !validRx || !validRy)
            {
                MessageBox.Show("Ingrese solo números válidos.", "Error de entrada");
                return;
            }

            if (rx <= 0 || ry <= 0)
            {
                MessageBox.Show("Los radios deben ser mayores que cero.", "Error de entrada");
                return;
            }
        }


        public void InitializeData(TextBox txtCentroX, TextBox txtCentroY, TextBox txtRadioX, TextBox txtRadioY, PictureBox picCanvas, DataGridView tabla)
        {
            xc = yc = rx = ry = 0;

            txtCentroX.Text = ""; txtCentroY.Text = ""; txtRadioX.Text = ""; txtRadioY.Text = "";
            txtCentroX.Focus();
            picCanvas.Refresh();
            tabla.Rows.Clear();
        }

        public void ConfigurarTabla(DataGridView tabla)
        {
            tabla.Columns.Clear();
            tabla.Columns.Add("Paso", "Paso");
            tabla.Columns.Add("X", "X");
            tabla.Columns.Add("Y", "Y");
        }

        public void PlotShape(PictureBox picCanvas, DataGridView tabla)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.DarkGreen, 1);
            tabla.Rows.Clear();

            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;

            int x = 0;
            int y = ry;

            double rx2 = rx * rx;
            double ry2 = ry * ry;
            double tworx2 = 2 * rx2;
            double twory2 = 2 * ry2;
            double px = 0;
            double py = tworx2 * y;

            int paso = 1;

            // Región 1
            double p1 = ry2 - (rx2 * ry) + (0.25 * rx2);
            while (px < py)
            {
                DrawSymmetricPoints(x, y, centerX, centerY, tabla, ref paso);
                x++;
                px += twory2;
                if (p1 < 0)
                {
                    p1 += ry2 + px;
                }
                else
                {
                    y--;
                    py -= tworx2;
                    p1 += ry2 + px - py;
                }
            }

            // Región 2
            double p2 = ry2 * (x + 0.5) * (x + 0.5) + rx2 * (y - 1) * (y - 1) - rx2 * ry2;
            while (y >= 0)
            {
                DrawSymmetricPoints(x, y, centerX, centerY, tabla, ref paso);
                y--;
                py -= tworx2;
                if (p2 > 0)
                {
                    p2 += rx2 - py;
                }
                else
                {
                    x++;
                    px += twory2;
                    p2 += rx2 - py + px;
                }
            }

            Pen ejePen = new Pen(Color.LightGray, 1);
            mGraph.DrawLine(ejePen, 0, centerY, picCanvas.Width, centerY);
            mGraph.DrawLine(ejePen, centerX, 0, centerX, picCanvas.Height);
        }

        private void AgregarPunto(DataGridView tabla, int x, int y, int paso)
        {
            tabla.Rows.Add(paso, x, y);
        }

        private void DrawSymmetricPoints(int x, int y, int centerX, int centerY, DataGridView tabla, ref int paso)
        {
            int cx = centerX + xc;
            int cy = centerY - yc;

            AgregarPunto(tabla, cx + x, cy + y, paso++);
            AgregarPunto(tabla, cx - x, cy + y, paso++);
            AgregarPunto(tabla, cx + x, cy - y, paso++);
            AgregarPunto(tabla, cx - x, cy - y, paso++);

            DrawPixel(cx + x, cy + y);
            DrawPixel(cx - x, cy + y);
            DrawPixel(cx + x, cy - y);
            DrawPixel(cx - x, cy - y);

            System.Threading.Thread.Sleep(50);
            Application.DoEvents();
        }

        private void DrawPixel(int x, int y)
        {
            mGraph.DrawRectangle(mPen, x, y, 1, 1);
        }
    


}
}
