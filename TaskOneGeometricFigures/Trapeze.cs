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
                float BaseMajor = float.Parse(txtBaseMajor.Text);
                float BaseMinor = float.Parse(txtBaseMinor.Text);
                float Height = float.Parse(txtHeight.Text);

                if (BaseMajor <= 0 || BaseMinor <= 0 || Height <= 0)
                {
                    MessageBox.Show("Las bases y la altura deben ser mayores a 0.", "Error");
                    this.mBaseMajor = 0.0f;
                    this.mBaseMinor = 0.0f;
                    this.mHeight = 0.0f;
                }
                else if (BaseMajor <= BaseMinor)
                {
                    MessageBox.Show("La base mayor debe ser mayor que la base menor.", "Error");
                    this.mBaseMajor = 0.0f;
                    this.mBaseMinor = 0.0f;
                    this.mHeight = 0.0f;
                }
                else
                {
                    this.mBaseMajor = BaseMajor;
                    this.mBaseMinor = BaseMinor;
                    this.mHeight = Height;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso  inválido. Asegúrese de ingresar números positivos.", "Error");
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
