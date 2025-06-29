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
    public partial class ElipseFrm : Form
    {
        private static ElipseFrm instance = null;
        ElipseBresenham elipse = new ElipseBresenham();

        public static ElipseFrm Instance
        {
            get
            {
                // Check if the Instance already exists
                if (instance == null)
                    instance = new ElipseFrm();
                return instance;
            }
        }

        public ElipseFrm()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ElipseFrm_Load(object sender, EventArgs e)
        {
            elipse.ConfigurarTabla(tabla);
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            elipse.ReadData(txtXc, txtYc, txtRadioX, txtRadioY);
            elipse.PlotShape(picCanvas, tabla);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            elipse.InitializeData(txtXc, txtYc, txtRadioX, txtRadioY, picCanvas, tabla);
        }
    }
}
