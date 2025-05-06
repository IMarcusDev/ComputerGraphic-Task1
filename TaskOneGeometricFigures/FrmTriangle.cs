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
    public partial class FrmTriangle : Form
    {
        private Triangle triangle = new Triangle();
        private PictureBox picCanvas;

        public FrmTriangle(PictureBox picCanvas)
        {
            InitializeComponent();
            this.picCanvas = picCanvas;
        }

        private void FrmTriangle_Load(object sender, EventArgs e)
        {
            triangle.InitData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            triangle.InitData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            triangle.ReadData(txtWidth, txtHeight);

            if (triangle.IsValid())
            {
                triangle.PerimeterTriangle();
                triangle.AreaTriangle();
                triangle.ShowData(txtPerimeter, txtArea);
                triangle.PlotShape(picCanvas);
            }
            else
            {
                MessageBox.Show("Los datos ingresados no forman un triángulo válido.", "Error");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            triangle.CloseForm(this);
        }
    }
}
