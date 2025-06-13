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

        //Leer los textBox
        public void LeerDatos(TextBox txtXi, TextBox txtYi, TextBox txtXf, TextBox txtYf)
        {
            if (txtXi.Text == "" || txtYi.Text == "" || txtXf.Text == "" || txtYf.Text == "")
            {
                throw new ArgumentException("Todos los campos deben ser llenados.");
            }
            xi = int.Parse(txtXi.Text);
            yi = int.Parse(txtYi.Text);
            x = int.Parse(txtXf.Text);
            y = int.Parse(txtYf.Text);
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
