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
    public partial class AnalizadorDiferencialDigitalFrm : Form
    {
        private static AnalizadorDiferencialDigitalFrm instance = null;
        AnalizadorDiferencialDigital analizadorDiferencialDigital = new AnalizadorDiferencialDigital();
        public AnalizadorDiferencialDigitalFrm()
        {
            InitializeComponent();
        }

        public static AnalizadorDiferencialDigitalFrm Instance
        {
            get
            {
                // Check if the Instance already exists
                if (instance == null)
                    instance = new AnalizadorDiferencialDigitalFrm();

                return instance;
            }
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            analizadorDiferencialDigital.LeerDatos(txtXi, txtYi, txtXf, txtYf);

            if (!analizadorDiferencialDigital.LeerDatos(txtXi, txtYi, txtXf, txtYf))
                return;

            analizadorDiferencialDigital.PlotShape(picCanvas, dataGridPuntos);
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {

        }

        private void txtYf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtXf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtXi_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnalizadorDiferencialDigitalFrm_Load(object sender, EventArgs e)
        {
            analizadorDiferencialDigital.ConfigurarTabla(dataGridPuntos);
        }

        private void dataGridPuntos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            analizadorDiferencialDigital.InicializarDatos(txtXi, txtXf, txtYi, txtYf, dataGridPuntos, picCanvas);
        }
    }
}
