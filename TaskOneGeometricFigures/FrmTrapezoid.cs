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
    public partial class FrmTrapezoid : Form
    {
        private Trapezoid trapezoid = new Trapezoid();
        private PictureBox picCanvas;
        public FrmTrapezoid(PictureBox picCanvas)
        {
            InitializeComponent();
            this.picCanvas = picCanvas;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            trapezoid.readData(txtSideA, txtSideB, txtSideC, txtSideD, txtHeight);

            if (trapezoid.isValid())
            {
                trapezoid.perimeterTrapezoid();
                trapezoid.areaTrapezoid();
                trapezoid.showData(txtPerimeter, txtArea);
                trapezoid.plotShape(picCanvas);
            }
            else
            {
                MessageBox.Show("Los datos ingresados no forman un trapecio válido.", "Error");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            trapezoid.initData(txtSideA, txtSideB, txtSideC, txtSideD, txtHeight, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            trapezoid.closeForm(this);
        }
    }
}
