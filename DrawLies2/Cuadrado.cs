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
    public class Cuadrado
    {
        private float side;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20; //scale factor
        private Pen mPen; // pen for drawing

        private Bitmap lienzo;
        private Color fillColor = Color.Red;
        private PictureBox pic;
        private DataGridView tabla;
        private int ordinal = 1;


        public Cuadrado()
        {
            side = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        public async Task FloodFillAsync(int x, int y, PictureBox picCanvas, DataGridView dgv)
        {
            this.pic = picCanvas;
            this.tabla = dgv;
            if (lienzo == null)
            {
                lienzo = new Bitmap(pic.Width, pic.Height);
                using (Graphics g = Graphics.FromImage(lienzo))
                {
                    g.Clear(Color.White);
                    Pen borderPen = new Pen(Color.Black, 3);
                    g.DrawRectangle(borderPen, 0, 0, side * SF, side * SF);
                }
                pic.Image = lienzo;
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


        //Function that read data input
        public void ReadData(TextBox txtSide)
        {
            if (float.Parse(txtSide.Text) <= 0 || txtSide.Text == "")
            {
                MessageBox.Show("Ingreso no válido....",
                                "Mensaje de error");
                txtSide.Focus();
                txtSide.Text = "";
                return;
            }
            try
            {

                side = float.Parse(txtSide.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido....",
                                "Mensaje de error");
            }
        }

        //Function that calculate perimeter of square
        public void PerimeterSquare()
        {
            mPerimeter = 4 * side;
        }

        //Function that calculate the area of square
        public void AreaSquare()
        {
            mArea = side * side;
        }

        public void ConfigurarTabla(DataGridView tabla)
        {
            tabla.Columns.Clear();
            tabla.Columns.Add("Ordinal", "Ordinal");
            tabla.Columns.Add("X", "X");
            tabla.Columns.Add("Y", "Y");
        }

        //Function that show perimeter and area of square
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        //Function that initialize data and controls
        public void InitializeData(TextBox txtSide,
                                    
                                    PictureBox picCanvas)
        {
            side = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtSide.Text = "";

            txtSide.Focus();
            picCanvas.Refresh();
        }

        //Funcstion that draw rectangle
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);

            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;

            //Draw rectangle
            mGraph.DrawRectangle(mPen, centerX, centerY, side * SF, side * SF);
            System.Threading.Thread.Sleep(70);
            Application.DoEvents();
        }

        //Function that close a formulary
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
