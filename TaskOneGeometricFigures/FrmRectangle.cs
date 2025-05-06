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
    public partial class FrmRectangle : Form
    {
        private Rectangle rectangle = new Rectangle();
        private PictureBox picCanvas;
        public FrmRectangle(PictureBox picCanvas)
        {
            InitializeComponent();
            this.picCanvas = picCanvas;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rectangle.initData(txtHeight, txtWidth, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            rectangle.readData(txtWidth, txtHeight);
            rectangle.perimeterRectangle();
            rectangle.areaRectangle();
            rectangle.showData(txtPerimeter, txtArea);
            rectangle.plotShape(picCanvas);
        }
    }
}
