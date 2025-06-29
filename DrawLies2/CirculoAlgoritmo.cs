using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLies2
{
    public class CirculoAlgoritmo
    {
        private int xc;
        private int yc;
        private int radio;
        private Graphics mGraph;
        private Pen mPen;

        public CirculoAlgoritmo()
        {
            xc = yc = radio = 0;
        }

        public bool ReadData(TextBox txtCentroX, TextBox txtCentroY, TextBox txtRadio)
        {
            if (string.IsNullOrWhiteSpace(txtCentroX.Text) ||
                string.IsNullOrWhiteSpace(txtCentroY.Text) ||
                string.IsNullOrWhiteSpace(txtRadio.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos.", "Entrada incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtCentroX.Text, out xc) || xc < 0 ||
                !int.TryParse(txtCentroY.Text, out yc) || yc < 0 ||
                !int.TryParse(txtRadio.Text, out radio) || radio <= 0)
            {
                MessageBox.Show("Ingrese valores numéricos enteros positivos. El radio debe ser mayor a cero.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        public void InitializeData(TextBox txtCentroX, TextBox txtCentroY, TextBox txtRadio, PictureBox picCanvas, DataGridView tabla)
        {
            xc = yc = radio = 0;

            txtCentroX.Text = ""; txtCentroY.Text = ""; txtRadio.Text = "";
            txtCentroX.Focus();
            picCanvas.Refresh();
            tabla.Rows.Clear();
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
            mPen = new Pen(Color.Blue, 1);
            tabla.Rows.Clear(); 

            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;

            int x = 0;
            int y = radio;
            int p = 1 - radio;

            int paso = 1;

            DrawSymmetricPoints(x, y, centerX, centerY, tabla, ref paso);

            while (x < y)
            {
                x++;
                if (p < 0)
                {
                    p += 2 * x + 1;
                }
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
                DrawSymmetricPoints(x, y, centerX, centerY, tabla, ref paso);
            }

            Pen ejePen = new Pen(Color.LightGray, 1);
            mGraph.DrawLine(ejePen, 0, centerY, picCanvas.Width, centerY);
            mGraph.DrawLine(ejePen, centerX, 0, centerX, picCanvas.Height);
        }

        private void AgregarPunto(DataGridView tabla, int x, int y,int pasos)
        {
            tabla.Rows.Add(pasos, x, y);
        }


        private void DrawSymmetricPoints(int x, int y, int centerX, int centerY, DataGridView tabla, ref int pasos)
        {
            int cx = centerX + xc;
            int cy = centerY - yc;

            AgregarPunto(tabla, cx + x, cy + y, pasos++);
            AgregarPunto(tabla, cx - x, cy + y, pasos++);
            AgregarPunto(tabla, cx + x, cy - y, pasos++);
            AgregarPunto(tabla, cx - x, cy - y, pasos++);
            AgregarPunto(tabla, cx + y, cy + x, pasos++);
            AgregarPunto(tabla, cx - y, cy + x, pasos++);
            AgregarPunto(tabla, cx + y, cy - x, pasos++);
            AgregarPunto(tabla, cx - y, cy - x, pasos++);

            DrawPixel(cx + x, cy + y);
            DrawPixel(cx - x, cy + y);
            DrawPixel(cx + x, cy - y);
            DrawPixel(cx - x, cy - y);
            DrawPixel(cx + y, cy + x);
            DrawPixel(cx - y, cy + x);
            DrawPixel(cx + y, cy - x);
            DrawPixel(cx - y, cy - x);

            System.Threading.Thread.Sleep(70);
            Application.DoEvents();

        }

        private void DrawPixel(int x, int y)
        {
            mGraph.DrawRectangle(mPen, x, y, 1, 1);
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
