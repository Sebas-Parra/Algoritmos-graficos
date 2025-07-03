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
    public partial class FrmScanline : Form
    {
        private static FrmScanline instance = null;
        Scanline objFiguraRelleno = new Scanline();
        public static FrmScanline Instance
        {
            get
            {
                // Check if the Instance already exists
                if (instance == null)
                    instance = new FrmScanline();
                return instance;
            }
        }


        public FrmScanline()
        {
            InitializeComponent();
        }

        private void FrmScanline_Load(object sender, EventArgs e)
        {
            objFiguraRelleno.InitializeData(txtLado, picCanvas);

            picCanvas.MouseClick += async (s, e2) =>
            {
                await objFiguraRelleno.ScanlineFillAsync(e2.X, e2.Y, picCanvas);
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
