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
    public partial class FrmHodgman : Form
    {
        private static FrmHodgman instance = null;
        private readonly Rectangle rectRecorte = new Rectangle(100, 100, 200, 100);
        private List<Point> puntosPoligono = new List<Point>();
        private List<Point> poligonoRecortado = new List<Point>();
        private bool mostrarRecortePoligono = false;

        public static FrmHodgman Instance
        {
            get
            {
                // Check if the Instance already exists
                if (instance == null)
                    instance = new FrmHodgman();
                return instance;
            }
        }

        public FrmHodgman()
        {
            InitializeComponent();

            picCanvas.MouseClick += pictureBox1_MouseClick;
            RedibujarTodo();
        }



        private void FrmHodgman_Load(object sender, EventArgs e)
        {

        }

        private void picCanvas_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
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

        private void RedibujarTodo()
        {
            Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                g.DrawRectangle(Pens.Blue, rectRecorte);

                if (puntosPoligono.Count > 1)
                    g.DrawPolygon(Pens.Gray, puntosPoligono.ToArray());

                foreach (var punto in puntosPoligono)
                    g.FillEllipse(Brushes.Black, punto.X - 2, punto.Y - 2, 4, 4);

                if (mostrarRecortePoligono && poligonoRecortado.Count > 1)
                {
                    List<Point> cerrado = new List<Point>(poligonoRecortado);
                    if (cerrado[0] != cerrado[cerrado.Count - 1])
                        cerrado.Add(cerrado[0]);
                    g.DrawLines(Pens.Red, cerrado.ToArray());
                }
            }

            picCanvas.Image?.Dispose();
            picCanvas.Image = bmp;
        }
    }
}
