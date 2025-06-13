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

            TitleDDA.Visible = false;
            btnAnalizadorDiferencial.Visible = false;
            TitleBresenham.Visible = false;
            btnBresenham.Visible = false;
            TitleCirculos.Visible = false;
            btnCircunferencia.Visible = false;
            TitleRelleno.Visible = false;
            lblTitleGeneral.Visible = false;
        }

        private void btnBresenham_Click(object sender, EventArgs e)
        {
            BresenhamFrm bresenhamFrm = BresenhamFrm.Instance;
            bresenhamFrm.MdiParent = this;
            bresenhamFrm.Show();

            TitleDDA.Visible = false;
            btnAnalizadorDiferencial.Visible = false;
            TitleBresenham.Visible = false;
            btnBresenham.Visible = false;
            TitleCirculos.Visible = false;
            btnCircunferencia.Visible = false;
            TitleRelleno.Visible = false;
            lblTitleGeneral.Visible = false;
        }

        private void btnCircunferencia_Click(object sender, EventArgs e)
        {
            CirculoFrm circuloFrm = CirculoFrm.Instance;
            circuloFrm.MdiParent = this;
            circuloFrm.Show();

            TitleDDA.Visible = false;
            btnAnalizadorDiferencial.Visible = false;
            TitleBresenham.Visible = false;
            btnBresenham.Visible = false;
            TitleCirculos.Visible = false;
            btnCircunferencia.Visible = false;
            TitleRelleno.Visible = false;
            lblTitleGeneral.Visible = false;
        }

        private void btnRelleno_Click(object sender, EventArgs e)
        {
            FrmCuadrado frmCuadrado = FrmCuadrado.Instance;
            frmCuadrado.MdiParent = this;
            frmCuadrado.Show();

            TitleDDA.Visible = false;
            btnAnalizadorDiferencial.Visible = false;
            TitleBresenham.Visible = false;
            btnBresenham.Visible = false;
            TitleCirculos.Visible = false;
            btnCircunferencia.Visible = false;
            TitleRelleno.Visible = false;
            lblTitleGeneral.Visible = false;
        }

        private void btnRellenoFiguras_Click(object sender, EventArgs e)
        {
            FrmFiguraRelleno frmFiguraRelleno = FrmFiguraRelleno.Instance;
            frmFiguraRelleno.MdiParent = this;
            frmFiguraRelleno.Show();

            TitleDDA.Visible = false;
            btnAnalizadorDiferencial.Visible = false;
            TitleBresenham.Visible = false;
            btnBresenham.Visible = false;
            TitleCirculos.Visible = false;
            btnCircunferencia.Visible = false;
            TitleRelleno.Visible = false;
            lblTitleGeneral.Visible = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
