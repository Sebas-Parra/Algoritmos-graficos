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
    public partial class BresenhamFrm : Form
    {
        private static BresenhamFrm instance = null;
        Bresenham Bresenham = new Bresenham();
        public BresenhamFrm()
        {
            InitializeComponent();
        }

        public static BresenhamFrm Instance
        {
            get
            {
                // Check if the Instance already exists
                if (instance == null)
                    instance = new BresenhamFrm();
                return instance;
            }
        }

        private void txtXi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            
        }

        private void BresenhamFrm_Load(object sender, EventArgs e)
        {
            Bresenham.ConfigurarTabla(dataGridPuntos);
        }

        private void btnGraficar_Click_1(object sender, EventArgs e)
        {
            Bresenham.ReadData(txtXi, txtYi, txtXf, txtYf);
            Bresenham.PlotShape(picCanvas, dataGridPuntos);
        }
    }
}
