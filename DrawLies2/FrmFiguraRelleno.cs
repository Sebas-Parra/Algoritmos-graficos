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
    public partial class FrmFiguraRelleno : Form
    {
        private static FrmFiguraRelleno instance = null;
        FiguraRelleno objFiguraRelleno = new FiguraRelleno();
        public FrmFiguraRelleno()
        {
            InitializeComponent();
        }

        public static FrmFiguraRelleno Instance
        {
            get
            {
                // Check if the Instance already exists
                if (instance == null)
                    instance = new FrmFiguraRelleno();
                return instance;
            }
        }

        private void FrmFiguraRelleno_Load(object sender, EventArgs e)
        {
            objFiguraRelleno.InitializeData(txtLado, picCanvas);
            objFiguraRelleno.ConfigurarTabla(dataGridPuntos);

            // Aquí se asocia el evento de clic
            picCanvas.MouseClick += async (s, e2) =>
            {
                await objFiguraRelleno.FloodFillAsync(e2.X, e2.Y, picCanvas, dataGridPuntos);
            };
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            objFiguraRelleno.ReadData(txtLado);
            objFiguraRelleno.PlotShape(picCanvas);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            objFiguraRelleno.InitializeData(txtLado, picCanvas);
        }
    }
}
