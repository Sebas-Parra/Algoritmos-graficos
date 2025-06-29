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
            this.IsMdiContainer = true;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAnalizadorDiferencial_Click(object sender, EventArgs e)
        {
            AnalizadorDiferencialDigitalFrm frmAnalizador = AnalizadorDiferencialDigitalFrm.Instance;
            frmAnalizador.MdiParent = this;
            frmAnalizador.Show();

            frmAnalizador.FormClosed += (s, args) => RestaurarControles();


            EliminarControles();
        }

        private void btnBresenham_Click(object sender, EventArgs e)
        {
            BresenhamFrm bresenhamFrm = BresenhamFrm.Instance;
            bresenhamFrm.MdiParent = this;
            bresenhamFrm.Show();

            bresenhamFrm.FormClosed += (s, args) => RestaurarControles();


            EliminarControles();
        }

        private void btnCircunferencia_Click(object sender, EventArgs e)
        {
            CirculoFrm circuloFrm = CirculoFrm.Instance;
            circuloFrm.MdiParent = this;
            circuloFrm.Show();

            circuloFrm.FormClosed += (s, args) => RestaurarControles();


            EliminarControles();
        }

        private void btnRelleno_Click(object sender, EventArgs e)
        {
            FrmCuadrado frmCuadrado = FrmCuadrado.Instance;
            frmCuadrado.MdiParent = this;
            frmCuadrado.Show();

            frmCuadrado.FormClosed += (s, args) => RestaurarControles();


            EliminarControles();
        }

        private void btnRellenoFiguras_Click(object sender, EventArgs e)
        {
            FrmFiguraRelleno frmFiguraRelleno = FrmFiguraRelleno.Instance;
            frmFiguraRelleno.MdiParent = this;
            frmFiguraRelleno.Show();

            frmFiguraRelleno.FormClosed += (s, args) => RestaurarControles();


            EliminarControles();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnBresenhamElipse_Click(object sender, EventArgs e)
        {
            ElipseFrm elipseFrm = new ElipseFrm();
            elipseFrm.MdiParent = this;
            elipseFrm.Show();

            elipseFrm.FormClosed += (s, args) => RestaurarControles();


            EliminarControles();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void btnScanline_Click(object sender, EventArgs e)
        {
            FrmScanline frmScanline = new FrmScanline();
            frmScanline.MdiParent = this;
            frmScanline.Show();

            frmScanline.FormClosed += (s, args) => RestaurarControles();


            EliminarControles();
        }

        private void btnCohenSutherland_Click(object sender, EventArgs e)
        {
            FrmCohenSutherland frmCohenSutherland = new FrmCohenSutherland();
            frmCohenSutherland.MdiParent = this;
            frmCohenSutherland.Show();

            frmCohenSutherland.FormClosed += (s, args) => RestaurarControles();


            EliminarControles();

        }

        private void btnSutherlandHodgman_Click(object sender, EventArgs e)
        {
            FrmHodgman frmHodgman = new FrmHodgman();
            frmHodgman.MdiParent = this;
            frmHodgman.Show();

            frmHodgman.FormClosed += (s, args) => RestaurarControles();


            EliminarControles();
        }

        private void btnBezier_Click(object sender, EventArgs e)
        {
            FrmBezierAnimado frmBezier = new FrmBezierAnimado();
            frmBezier.MdiParent = this;
            frmBezier.Show();

            frmBezier.FormClosed += (s, args) => RestaurarControles();

            EliminarControles();
        }

        private void btnBSplines_Click(object sender, EventArgs e)
        {
            FrmBSpline frmBSpline = new FrmBSpline();
            frmBSpline.MdiParent = this;
            frmBSpline.Show();

            frmBSpline.FormClosed += (s, args) => RestaurarControles();


            EliminarControles();
        }

        public void EliminarControles()
        {
            TitleDDA.Visible = false;
            btnAnalizadorDiferencial.Visible = false;
            TitleBresenham.Visible = false;
            btnBresenham.Visible = false;
            TitleCirculos.Visible = false;
            btnCircunferencia.Visible = false;
            TitleRelleno.Visible = false;
            lblTitleGeneral.Visible = false;
            TitleElipses.Visible = false;
            btnBresenhamElipse.Visible = false;
            TitleScanline.Visible = false;
            btnScanline.Visible = false;
            TitleCohenSutherland.Visible = false;
            btnCohenSutherland.Visible = false;
            TitleSutherladnHodgman.Visible = false;
            btnSutherlandHodgman.Visible = false;
            TitleBezier.Visible = false;
            btnBezier.Visible = false;
            TitleBSplines.Visible = false;
            btnBSplines.Visible = false;
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;

        }

        public void RestaurarControles()
        {
            TitleDDA.Visible = true;
            btnAnalizadorDiferencial.Visible = true;
            TitleBresenham.Visible = true;
            btnBresenham.Visible = true;
            TitleCirculos.Visible = true;
            btnCircunferencia.Visible = true;
            TitleRelleno.Visible = true;
            lblTitleGeneral.Visible = true;
            TitleElipses.Visible = true;
            btnBresenhamElipse.Visible = true;
            TitleScanline.Visible = true;
            btnScanline.Visible = true;
            TitleCohenSutherland.Visible = true;
            btnCohenSutherland.Visible = true;
            TitleSutherladnHodgman.Visible = true;
            btnSutherlandHodgman.Visible = true;
            TitleBezier.Visible = true;
            btnBezier.Visible = true;
            TitleBSplines.Visible = true;
            btnBSplines.Visible = true;
        }

    
    }
}
