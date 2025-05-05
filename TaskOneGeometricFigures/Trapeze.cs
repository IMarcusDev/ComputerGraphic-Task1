using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskOneGeometricFigures
{
    internal class Trapeze
    {
        protected float mBaseMajor;
        protected float mBaseMinor;
        protected float mHeight;
        protected float mPerimeter;
        protected float mArea;
        protected const float SF = 20;
        protected Graphics mGraph;
        protected Pen mPen;

        public Trapeze()
        {
            this.mArea = 0.0f; this.mPerimeter = 0.0f;
            this.mBaseMajor = 0.0f; this.mBaseMinor = 0.0f;
            this.mHeight = 0.0f;
        }

        public void readData(TextBox txtBaseMajor, TextBox txtBaseMinor, TextBox txtHeight)
        {
            try
            {
                if (float.Parse(txtHeight.Text) > 0 && float.Parse(txtBaseMinor.Text) > 0 && float.Parse(txtBaseMajor.Text) > 0)
                {
                    this.mHeight = float.Parse(txtHeight.Text);
                    this.mBaseMinor = float.Parse(txtBaseMinor.Text);
                    this.mBaseMajor = float.Parse(txtBaseMajor.Text);
                }
            }
            catch
            {
                MessageBox.Show("Ingreso invalido, solo numeros", "Error");
            }
        }

        public void perimeterTrapeze()
        {
            this.mPerimeter = this.mBaseMajor + this.mBaseMinor + 2 * this.mHeight;
        }

        public void areaTrapeze()
        {
            this.mArea = (this.mHeight / 2) * (this.mBaseMajor + this.mBaseMinor);
        }

        public void initData(TextBox txtHeight, TextBox txtBaseMajor, TextBox txtBaseMinor, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            txtArea.Clear();
            txtHeight.Clear();
            txtBaseMajor.Clear();
            txtBaseMinor.Clear();
            txtPerimeter.Clear();

            this.mArea = 0.0f; this.mHeight = 0.0f;
            this.mBaseMajor = 0.0f;
            this.mBaseMinor = 0.0f;
            this.mPerimeter = 0.0f;

            txtBaseMajor.Focus();
            picCanvas.Refresh();
        }

        public void showData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtArea.Text = this.mArea.ToString();
            txtPerimeter.Text = this.mPerimeter.ToString();
        }

        public void closeForm(Form form)
        {
            form.Close();
        }

        public void plotShape(PictureBox picCanvas)
        {
            this.mGraph = picCanvas.CreateGraphics();
            this.mPen = new Pen(Color.Blue, 3);
            
            float pMedioBaseMajor = this.mBaseMajor/2;
            float pMedioBaseMinor = this.mBaseMinor/2;

            PointF point1 = new PointF(0, this.mHeight * SF);
            PointF point2 = new PointF(this.mBaseMajor * SF, this.mHeight * SF);
            PointF point3 = new PointF((pMedioBaseMajor + pMedioBaseMinor) * SF, 0);
            PointF point4 = new PointF((pMedioBaseMajor - pMedioBaseMinor) * SF, 0);

            PointF[] points = new PointF[] { point1, point2, point3, point4 };
            
            mGraph.DrawPolygon(this.mPen, points);
        }
    }
}
