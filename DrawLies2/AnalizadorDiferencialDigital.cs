using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Resolvers;

namespace DrawLies2
{
    public class AnalizadorDiferencialDigital
    {
        int xi, yi, x, y;
        int diferencialX, diferencialY;
        private Graphics mGraph;
        private const float SF = 10;
        private Pen mPen;
        public AnalizadorDiferencialDigital()
        {
            this.xi = 0;
            this.yi = 0;
            this.x = 0;
            this.y = 0;
        }

        public void InicializarDatos(TextBox txtXi, TextBox txtYi, TextBox txtXf, TextBox txtYf,
                              DataGridView tabla, PictureBox canvas)
        {
            
            txtXi.Text = "";
            txtYi.Text = "";
            txtXf.Text = "";
            txtYf.Text = "";

            tabla.Rows.Clear();
            tabla.Columns.Clear();
            tabla.Columns.Add("Ordinal", "Ordinal");
            tabla.Columns.Add("X", "X");
            tabla.Columns.Add("Y", "Y");

            
            using (Graphics g = canvas.CreateGraphics())
            {
                g.Clear(Color.White);
                
            }
        }

        //Leer los textBox
        public bool LeerDatos(TextBox txtXi, TextBox txtYi, TextBox txtXf, TextBox txtYf)
        {
            if (string.IsNullOrWhiteSpace(txtXi.Text) ||
                string.IsNullOrWhiteSpace(txtYi.Text) ||
                string.IsNullOrWhiteSpace(txtXf.Text) ||
                string.IsNullOrWhiteSpace(txtYf.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtXi.Text, out xi) || !int.TryParse(txtYi.Text, out yi) ||
                !int.TryParse(txtXf.Text, out x) || !int.TryParse(txtYf.Text, out y))
            {
                MessageBox.Show("Todos los valores deben ser números enteros válidos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (xi < 0 || yi < 0 || x < 0 || y < 0)
            {
                MessageBox.Show("Los valores deben ser números enteros positivos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true; // Todo fue correcto
        }





        public float calcularDiferencialX(int x, int xi)
        {
            if (x == xi)
            {
                throw new DivideByZeroException("La diferencia en X no puede ser cero.");
            }
            diferencialX = x - xi;
            return (float)diferencialX;
        }

        public float calcularDiferencialY(int y, int yi)
        {
            if (y == yi)
            {
                throw new DivideByZeroException("La diferencia en Y no puede ser cero.");
            }
            diferencialY = y - yi;
            return (float)diferencialY;
        }

        
        public float calcularPendiente()
        {
            float dx = calcularDiferencialX(x, xi);
            float dy = calcularDiferencialY(y, yi);
            return dy/dx;
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
            mPen = new Pen(Color.Blue, 3);
            mGraph.Clear(Color.White); // Limpiar canvas al inicio
            int pasos = Math.Max(Math.Abs(x - xi), Math.Abs(y - yi));

            
            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;
            float yAux = yi;
            float xAux = xi;
            float m = calcularPendiente();
            float dx = calcularDiferencialX(x, xi);
            float dy = calcularDiferencialY(y, yi);
            for (int i = 0; i <= pasos; i++)
            {
                int xCanvas = (int)Math.Round(centerX + xAux);
                int yCanvas = (int)Math.Round(centerY - yAux);

                mGraph.DrawRectangle(mPen, xCanvas, yCanvas, 1, 1);

                
                tabla.Rows.Add(pasos, (int)xAux, (int)yAux);

                Thread.Sleep(70);
                Application.DoEvents();


                if (Math.Abs(m) <= 1)
                {
                    if (dx >= 0)
                    {
                        xAux += 1;
                        yAux += m;
                    }
                    else
                    {
                        xAux -= 1;
                        yAux -= m;
                    }

                }
                else
                {
                    if (dy >= 0)
                    {
                        yAux += 1;
                        xAux += 1 / m;
                    }
                    else
                    {
                        yAux -= 1;
                        xAux -= 1 / m;
                    }
                }
            }
            Pen ejePen = new Pen(Color.Black, 2);
            mGraph.DrawLine(ejePen, 0,centerY, picCanvas.Width, centerY);
            mGraph.DrawLine(ejePen, centerX, 0, centerX, picCanvas.Height);

        }






    }
}
