using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace TaskOneGeometricFigures
{
    public partial class FrmCircle : Form
    {
    private Circle circle = new Circle();
        public FrmCircle()
        {
            InitializeComponent();
        }

        private void FrmCircle_Load(object sender, EventArgs e)
        {
            circle.initData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            circle.initData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            circle.readData(txtRadius);
            circle.perimeterCircle();
            circle.areaCircle();
            circle.showData(txtPerimeter, txtArea);
            circle.plotShape(picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            circle.closeForm(this);
        }
    }
}
