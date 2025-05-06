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
    public partial class FrmEllipse : Form
    {
        private Ellipse ellipse = new Ellipse();
        private PictureBox picCanvas;
        public FrmEllipse(PictureBox picCanvas)
        {
            InitializeComponent();
            this.picCanvas = picCanvas;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ellipse.initData(txtMajorAxis, txtMinorAxis, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ellipse.readData(txtMajorAxis, txtMinorAxis);

            if (ellipse.IsValid())
            {
                ellipse.perimeterEllipse();
                ellipse.areaEllipse();
                ellipse.showData(txtPerimeter, txtArea);
                ellipse.plotShape(picCanvas);
            }
            else
            {
                MessageBox.Show("Los datos ingresados no forman una elipse válida.", "Error");
            }
        }
    }
}
