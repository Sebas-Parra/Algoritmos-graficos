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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            // Quitar si estaba antes
            // this.IsMdiContainer = true;
        }

        private void Home_Load(object sender, EventArgs e)
        {
        }

        private void btnAnalizadorDiferencial_Click(object sender, EventArgs e)
        {
            AnalizadorDiferencialDigitalFrm frmAnalizador = AnalizadorDiferencialDigitalFrm.Instance;
            this.Hide();
            frmAnalizador.Show();
            frmAnalizador.FormClosed += (s, args) => this.Show();
        }

        private void btnBresenham_Click(object sender, EventArgs e)
        {
            BresenhamFrm bresenhamFrm = BresenhamFrm.Instance;
            this.Hide();
            bresenhamFrm.Show();
            bresenhamFrm.FormClosed += (s, args) => this.Show();
        }

        private void btnCircunferencia_Click(object sender, EventArgs e)
        {
            CirculoFrm circuloFrm = CirculoFrm.Instance;
            this.Hide();
            circuloFrm.Show();
            circuloFrm.FormClosed += (s, args) => this.Show();
        }

        private void btnRelleno_Click(object sender, EventArgs e)
        {
            FrmCuadrado frmCuadrado = FrmCuadrado.Instance;
            this.Hide();
            frmCuadrado.Show();
            frmCuadrado.FormClosed += (s, args) => this.Show();
        }

        private void btnRellenoFiguras_Click(object sender, EventArgs e)
        {
            FrmFiguraRelleno frmFiguraRelleno = FrmFiguraRelleno.Instance;
            this.Hide();
            frmFiguraRelleno.Show();
            frmFiguraRelleno.FormClosed += (s, args) => this.Show();
        }

        private void btnBresenhamElipse_Click(object sender, EventArgs e)
        {
            ElipseFrm elipseFrm = new ElipseFrm();
            this.Hide();
            elipseFrm.Show();
            elipseFrm.FormClosed += (s, args) => this.Show();
        }

        private void btnScanline_Click(object sender, EventArgs e)
        {
            FrmScanline frmScanline = new FrmScanline();
            this.Hide();
            frmScanline.Show();
            frmScanline.FormClosed += (s, args) => this.Show();
        }

        private void btnCohenSutherland_Click(object sender, EventArgs e)
        {
            FrmCohenSutherland frmCohenSutherland = new FrmCohenSutherland();
            this.Hide();
            frmCohenSutherland.Show();
            frmCohenSutherland.FormClosed += (s, args) => this.Show();
        }

        private void btnSutherlandHodgman_Click(object sender, EventArgs e)
        {
            FrmHodgman frmHodgman = new FrmHodgman();
            this.Hide();
            frmHodgman.Show();
            frmHodgman.FormClosed += (s, args) => this.Show();
        }

        private void btnBezier_Click(object sender, EventArgs e)
        {
            FrmBezierAnimado frmBezier = new FrmBezierAnimado();
            this.Hide();
            frmBezier.Show();
            frmBezier.FormClosed += (s, args) => this.Show();
        }

        private void btnBSplines_Click(object sender, EventArgs e)
        {
            FrmBSpline frmBSpline = new FrmBSpline();
            this.Hide();
            frmBSpline.Show();
            frmBSpline.FormClosed += (s, args) => this.Show();
        }


    }
}
