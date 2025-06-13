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
    public partial class CirculoFrm : Form
    {
        private static CirculoFrm instance = null;
        CirculoAlgoritmo circuloAlgoritmo = new CirculoAlgoritmo();
        public CirculoFrm()
        {
            InitializeComponent();
        }

        public static CirculoFrm Instance
        {
            get
            {
                // Check if the Instance already exists
                if (instance == null)
                    instance = new CirculoFrm();
                return instance;
            }
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            circuloAlgoritmo.ReadData(txtXc, txtYc, txtRadio);
            circuloAlgoritmo.PlotShape(picCanvas, dataGridPuntos);
        }

        private void CirculoFrm_Load(object sender, EventArgs e)
        {
            circuloAlgoritmo.ConfigurarTabla(dataGridPuntos);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            circuloAlgoritmo.InitializeData(txtXc, txtYc, txtRadio, picCanvas, dataGridPuntos);
        }
    }
}
