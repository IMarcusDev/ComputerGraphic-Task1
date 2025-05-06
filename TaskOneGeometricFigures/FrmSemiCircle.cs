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
    public partial class FrmSemiCircle : Form
    {
        private SemiCircle semicircle = new SemiCircle();
        private PictureBox picCanvas;
        public FrmSemiCircle(PictureBox picCanvas)
        {
            InitializeComponent();
            this.picCanvas = picCanvas;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            semicircle.initData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            semicircle.readData(txtRadius);

            if (semicircle.IsValid())
            {
                semicircle.perimeterCircle();
                semicircle.areaCircle();
                semicircle.showData(txtPerimeter, txtArea);
                semicircle.plotShape(picCanvas);
            }
            else
            {
                MessageBox.Show("Los datos ingresados no forman un semicírculo válido.", "Error");
            }
        }
    }
}
