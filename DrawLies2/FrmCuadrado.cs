using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace DrawLies2
{
    public partial class FrmCuadrado : Form
    {
        private static FrmCuadrado instance = null;
        Cuadrado ObjSquare = new Cuadrado();
        public FrmCuadrado()
        {
            InitializeComponent();
        }

        public static FrmCuadrado Instance
        {
            get
            {
                // Check if the Instance already exists
                if (instance == null)
                    instance = new FrmCuadrado();
                return instance;
            }
        }

        private void FrmCuadrado_Load(object sender, EventArgs e)
        {
            ObjSquare.InitializeData(txtSide, picCanvas, dataGridPuntos);
            ObjSquare.ConfigurarTabla(dataGridPuntos);

            // Aquí se asocia el evento de clic
            picCanvas.MouseClick += async (s, e2) =>
            {
                await ObjSquare.FloodFillAsync(e2.X, e2.Y, picCanvas, dataGridPuntos);
            };

        }



        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjSquare.ReadData(txtSide);
            ObjSquare.PlotShape(picCanvas);
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjSquare.InitializeData(txtSide, picCanvas, dataGridPuntos);
        }
    }
}
