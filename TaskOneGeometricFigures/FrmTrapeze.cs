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
    public partial class FrmTrapeze : Form
    {
        private Trapeze trapeze = new Trapeze();
        private PictureBox picCanvas;
        public FrmTrapeze(PictureBox picCanvas)
        {
            InitializeComponent();
            this.picCanvas = picCanvas;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            trapeze.initData(txtHeight, txtBaseMajor, txtBaseMinor, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            trapeze.readData(txtBaseMajor, txtBaseMinor, txtHeight);

            if (trapeze.IsValid())
            {
                trapeze.perimeterTrapeze();
                trapeze.areaTrapeze();
                trapeze.showData(txtPerimeter, txtArea);
                trapeze.plotShape(picCanvas);
            }
            else
            {
                MessageBox.Show("Los datos ingresados no forman un trapecio válido.", "Error");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            trapeze.closeForm(this);
        }
    }
}
