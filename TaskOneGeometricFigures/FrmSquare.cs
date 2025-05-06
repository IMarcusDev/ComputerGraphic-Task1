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
    public partial class FrmSquare : Form
    {
        private Square square = new Square();
        private PictureBox picCanvas;
        public FrmSquare(PictureBox picCanvas)
        {
            InitializeComponent();
            this.picCanvas = picCanvas;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            square.initData(txtWidth, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            square.readData(txtWidth);
            square.perimeterSquare();
            square.areaSquare();
            square.showData(txtPerimeter, txtArea);
            square.plotShape(picCanvas);
        }
    }
}
