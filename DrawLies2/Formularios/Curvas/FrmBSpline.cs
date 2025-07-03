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
    public partial class FrmBSpline : Form
    {
        private static FrmBSpline instance = null;
        CurvaBSpline curva = new CurvaBSpline();
        private PointF? puntoSeleccionado = null;
        private int indiceSeleccionado = -1;
        private Timer animacion;

        public static FrmBSpline Instance
        {
            get
            {
                // Check if the Instance already exists
                if (instance == null)
                    instance = new FrmBSpline();
                return instance;
            }
        }

        public FrmBSpline()
        {
            InitializeComponent();
            picCanvas.MouseDown += picCanvas_MouseDown;
            picCanvas.MouseMove += picCanvas_MouseMove;
            picCanvas.MouseUp += picCanvas_MouseUp;

            picCanvas.MouseClick += PicCanvas_MouseClick;

            animacion = new Timer();
            animacion.Interval = 30;
            animacion.Tick += Animacion_Tick;
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {

        }

        private void PicCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                curva.AgregarPunto(e.Location);
                curva.GenerarCurvaCompleta();
                Redibujar();
            }
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < curva.PuntosControl.Count; i++)
            {
                var p = curva.PuntosControl[i];
                var distancia = Math.Sqrt(Math.Pow(e.X - p.X, 2) + Math.Pow(e.Y - p.Y, 2));
                if (distancia < 6)
                {
                    puntoSeleccionado = p;
                    indiceSeleccionado = i;
                    break;
                }
            }
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (puntoSeleccionado.HasValue && indiceSeleccionado != -1 && e.Button == MouseButtons.Left)
            {
                curva.PuntosControl[indiceSeleccionado] = e.Location;
                curva.GenerarCurvaCompleta(); // Regenera la curva automáticamente
                Redibujar();
            }
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            puntoSeleccionado = null;
            indiceSeleccionado = -1;
        }

        private void Animacion_Tick(object sender, EventArgs e)
        {
            var punto = curva.AvanzarPaso();
            if (punto.HasValue)
            {
                Redibujar();
            }
            else
            {
                animacion.Stop();
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            curva.Reset();
            Redibujar();
        }

        private void Redibujar()
        {
            Bitmap bmp = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                foreach (var p in curva.PuntosControl)
                    g.FillEllipse(Brushes.Black, p.X - 3, p.Y - 3, 6, 6);

                if (curva.PuntosControl.Count > 1)
                    g.DrawLines(Pens.Gray, curva.PuntosControl.ToArray());

                if (curva.CurvaGenerada.Count > 1)
                    g.DrawLines(Pens.Red, curva.CurvaGenerada.ToArray());
            }

            picCanvas.Image?.Dispose();
            picCanvas.Image = bmp;
        }

        private void FrmBSpline_Load(object sender, EventArgs e)
        {

        }
    }
}
