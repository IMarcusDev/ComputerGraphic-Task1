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
        public FrmTrapeze()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            trapeze.initData(txtHeight, txtBaseMajor, txtBaseMinor, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            trapeze.readData(txtBaseMajor, txtBaseMinor, txtHeight);
            trapeze.perimeterTrapeze();
            trapeze.areaTrapeze();
            trapeze.showData(txtPerimeter, txtArea);
            trapeze.plotShape(picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            trapeze.closeForm(this);
        }
    }
}
