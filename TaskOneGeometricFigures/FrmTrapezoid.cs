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
        public FrmTrapezoid()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            trapezoid.readData(txtSideA, txtSideB, txtDiagA, txtDiagB, txtHeight);
            trapezoid.perimeterTrapezoid();
            trapezoid.areaTrapezoid();
            trapezoid.showData(txtPerimeter, txtArea);
            trapezoid.plotShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            trapezoid.initData(txtSideA, txtSideB, txtDiagA, txtDiagB, txtHeight, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            trapezoid.closeForm(this);
        }
    }
}
