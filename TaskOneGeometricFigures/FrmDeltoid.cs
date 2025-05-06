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
    public partial class FrmDeltoid : Form
    {
        private Deltoid deltoide = new Deltoid();
        private PictureBox picCanvas;
        public FrmDeltoid(PictureBox picCanvas)
        {
            InitializeComponent();
            this.picCanvas = picCanvas;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            deltoide.initData(txtMajorAxis, txtMinorAxis, txtWidth, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            deltoide.readData(txtMajorAxis, txtMinorAxis, txtWidth);
            deltoide.perimeterDeltoid();
            deltoide.areaDeltoid();
            deltoide.showData(txtPerimeter, txtArea);
            deltoide.plotShape(picCanvas);
        }
    }
}
