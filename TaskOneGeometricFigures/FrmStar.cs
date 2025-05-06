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
    public partial class FrmStar : Form
    {
        private Star star = new Star();
        private PictureBox picCanvas;
        public FrmStar(PictureBox picCanvas)
        {
            InitializeComponent();
            this.picCanvas = picCanvas;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            star.readData(txtOuterRadius, txtInnerRadius);
            star.showData(txtPerimeter, txtArea);
            star.plotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            star.initData(txtOuterRadius, txtInnerRadius, picCanvas);
        }
    }
}
