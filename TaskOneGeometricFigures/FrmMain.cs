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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void openChildForm(object childForm)
        {
            if (childForm == null)
            {
                MessageBox.Show("El formulario no puede ser nulo.", "Error");
                return;
            }

            if (this.panelContainer.Controls.Count > 0) this.panelContainer.Controls.RemoveAt(0);
            Form fh = childForm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(fh);
            this.panelContainer.Tag = fh;
            fh.Show();
        }

        public PictureBox GetPictureBox()
        {
            return picCanvas;
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            FrmTriangle frmTriangle = new FrmTriangle(GetPictureBox());
            openChildForm(frmTriangle);
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCircle(GetPictureBox()));
        }

        private void btnTrapeze_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmTrapeze(GetPictureBox()));
        }

        private void btnDeltoid_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDeltoid(GetPictureBox()));
        }

        private void btnSemicircle_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmSemiCircle(GetPictureBox()));
        }

        private void btnDiamond_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDiamond(GetPictureBox()));
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmEllipse(GetPictureBox()));
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmRectangle(GetPictureBox()));
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmSquare(GetPictureBox()));
        }

        private void btnTrapezoid_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmTrapezoid(GetPictureBox()));
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmStar(GetPictureBox()));
        }

        private void btnRhomboid_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmRhomboid(GetPictureBox()));
        }
    }
}
