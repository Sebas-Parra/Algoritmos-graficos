using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawLies2
{
    public partial class FrmCohenSutherland : Form
    {
        private static FrmCohenSutherland instance = null;
        private Point? puntoInicio = null;
        private Point? puntoFin = null;

        private readonly System.Drawing.Rectangle rectRecorte = new System.Drawing.Rectangle(100, 100, 200, 100);

        private List<Point> puntosPoligono = new List<Point>();
        private bool mostrarRecortePoligono = false;
        private List<Point> poligonoRecortado = new List<Point>();

        public static FrmCohenSutherland Instance
        {
            get
            {
                // Check if the Instance already exists
                if (instance == null)
                    instance = new FrmCohenSutherland();
                return instance;
            }
        }

        public FrmCohenSutherland()
        {
            InitializeComponent();
            picCanvas.Image = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.MouseClick += pictureBox1_MouseClick;

            RedibujarTodo();

        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmCohenSutherland_Load(object sender, EventArgs e)
        {
            
        }

        private void SubscribeMouseClickRecursively(Control.ControlCollection controls)
        {
            
        }

  

        private void GlobalMouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                puntosPoligono.Add(e.Location);
                mostrarRecortePoligono = false;
                RedibujarTodo();
            }
            else if (e.Button == MouseButtons.Right && puntosPoligono.Count >= 3)
            {
                poligonoRecortado = SutherlandHodgman.ClipPolygon(puntosPoligono, rectRecorte);
                mostrarRecortePoligono = true;
                RedibujarTodo();
            }
        }



        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            

        }

        private void RedibujarTodo()
        {
            var bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                g.DrawRectangle(Pens.Blue, rectRecorte);

                if (puntosPoligono.Count > 1)
                {
                    g.DrawPolygon(Pens.Gray, puntosPoligono.ToArray());
                }

                foreach (var punto in puntosPoligono)
                {
                    g.FillEllipse(Brushes.Black, punto.X - 2, punto.Y - 2, 4, 4);
                }

                if (mostrarRecortePoligono && poligonoRecortado.Count > 1)
                {
                    List<Point> cerrado = new List<Point>(poligonoRecortado);

                    if (cerrado[0] != cerrado[cerrado.Count - 1])
                    {
                        cerrado.Add(cerrado[0]); // Cierra el polígono
                    }

                    g.DrawLines(Pens.Red, cerrado.ToArray()); // Dibuja con líneas explícitas
                }

            }

            picCanvas.Image?.Dispose();
            picCanvas.Image = bmp;
        }


        private void AplicarRecorte()
        {
            var bmp = new Bitmap(picCanvas.Image);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                var (x1, y1) = (puntoInicio.Value.X, puntoInicio.Value.Y);
                var (x2, y2) = (puntoFin.Value.X, puntoFin.Value.Y);

                var handler = new CohenSutherland(
                    rectRecorte.Left,
                    rectRecorte.Right,
                    rectRecorte.Top,
                    rectRecorte.Bottom
                );

                bool visible = handler.clipLine(x1, y1, x2, y2);

                if (visible)
                {
                    var clipped = handler.GetClippedLine();
                    if (clipped.HasValue)
                    {
                        var (cx1, cy1, cx2, cy2) = clipped.Value;
                        g.DrawLine(Pens.Red, cx1, cy1, cx2, cy2);
                    }
                }
                else
                {
                    MessageBox.Show("La línea está completamente fuera del área.");
                }
            }

            picCanvas.Image?.Dispose();
            picCanvas.Image = bmp;
        }


        private void FrmCohenSutherland_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            puntosPoligono.Clear();
            poligonoRecortado.Clear();
            mostrarRecortePoligono = false;
            RedibujarTodo();
        }
    }
}
