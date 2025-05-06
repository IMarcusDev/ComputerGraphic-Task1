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
    public partial class FrmRhomboid : Form
    {
        private Rhomboid romboide = new Rhomboid();
        private PictureBox picCanvas;
        public FrmRhomboid(PictureBox picCanvas)
        {
            InitializeComponent();
            this.picCanvas = picCanvas;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            romboide.initData(txtHeight, txtWidth, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            romboide.readData(txtWidth, txtHeight);
            romboide.perimeterRhomboid();
            romboide.areaRhomboid();
            romboide.showData(txtPerimeter, txtArea);
            romboide.plotShape(picCanvas);
        }
    }
}
