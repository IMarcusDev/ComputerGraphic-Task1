using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TaskOneGeometricFigures
{
    internal class Circle
    {
        private float mRadius;
        private float mPerimeter;
        private float mArea;
        private const float SF = 20;
        private Graphics mGraph;
        private Pen mPen;

        public Circle()
        {
            this.mRadius = 0.0f;
            this.mPerimeter = 0.0f; this.mArea = 0.0f ;
        }

        public void readData(TextBox txtRadius)
        {
            this.mRadius = float.Parse(txtRadius.Text);
        }

        public void perimeterCircle()
        {
            this.mPerimeter = 2 * (float) Math.PI * this.mRadius;
        }

        public void areaCircle()
        {
            this.mArea = (float) Math.PI * this.mRadius * this.mRadius;
        }

        public void showData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = this.mPerimeter.ToString();
            txtArea.Text = this.mArea.ToString();
        }

        public void initData(TextBox txtRadius, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            this.mRadius = 0.0f;
            this.mPerimeter = 0.0f; this.mArea = 0.0f;

            txtRadius.Text = ""; txtPerimeter.Text = "";
            txtArea.Text = "";

            txtRadius.Focus();
            picCanvas.Refresh();
        }

        public void plotShape(PictureBox picCanvas)
        {
            this.mGraph = picCanvas.CreateGraphics();
            this.mPen = new Pen(Color.Blue, 3);

            float diameter = this.mRadius * 2 * SF;

            this.mGraph.DrawEllipse(this.mPen, 0, 0, diameter, diameter);
        }

        public void closeForm(Form form)
        {
            form.Close();
        }
    }
}
