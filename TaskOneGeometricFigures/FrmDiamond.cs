using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskOneGeometricFigures
{
    public partial class FrmDiamond : Form
    {
        private Diamond diamond = new Diamond();
        private PictureBox picCanvas;
        public FrmDiamond(PictureBox picCanvas)
        {
            InitializeComponent();
            this.picCanvas = picCanvas;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            diamond.initData(txtMajorDiag, txtMinorDiag, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            diamond.readData(txtMajorDiag, txtMinorDiag);
            diamond.perimeterDiamond();
            diamond.areaDiamond();
            diamond.showData(txtPerimeter, txtArea);
            diamond.plotShape(picCanvas);
        }
    }
}
