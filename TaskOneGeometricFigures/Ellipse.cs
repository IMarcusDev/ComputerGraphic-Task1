using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskOneGeometricFigures
{
    internal class Ellipse
    {
        private float mMajorAxis;
        private float mMinorAxis;
        private float mPerimeter;
        private float mArea;
        private const float SF = 20;
        private Graphics mGraph;
        private Pen mPen;

        public Ellipse()
        {
            this.mMajorAxis = 0.0f; this.mMinorAxis = 0.0f;
            this.mPerimeter = 0.0f; this.mArea = 0.0f;
        }

        public void readData(TextBox txtMajorAxis, TextBox txtMinorAxis)
        {
            this.mMajorAxis = float.Parse(txtMajorAxis.Text);
            this.mMinorAxis = float.Parse(txtMinorAxis.Text);
        }

        public void perimeterCircle()
        {
            float a2 = this.mMajorAxis * this.mMajorAxis;
            float b2 = this.mMinorAxis * this.mMinorAxis;

            this.mPerimeter = 2 * (float)Math.PI * (float)Math.Sqrt((a2 + b2)/2);
        }

        public void areaCircle()
        {
            this.mArea = (float)Math.PI * this.mMajorAxis * this.mMinorAxis;
        }

        public void showData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = this.mPerimeter.ToString();
            txtArea.Text = this.mArea.ToString();
        }

        public void initData(TextBox txtMajorAxis,TextBox txtMinorAxis, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            this.mMajorAxis = 0.0f; this.mMinorAxis = 0.0f;
            this.mPerimeter = 0.0f; this.mArea = 0.0f;

            txtMajorAxis.Text = ""; txtPerimeter.Text = "";
            txtArea.Text = ""; txtMinorAxis.Text = "";

            txtMajorAxis.Focus();
            picCanvas.Refresh();
        }

        public void plotShape(PictureBox picCanvas)
        {
            this.mGraph = picCanvas.CreateGraphics();
            this.mPen = new Pen(Color.Blue, 3);

            this.mGraph.DrawEllipse(this.mPen, 0, 0, 2 * this.mMajorAxis, 2 * this.mMinorAxis);
        }

        public void closeForm(Form form)
        {
            form.Close();
        }
    }
}
