using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskOneGeometricFigures
{
    internal class Deltoid
    {
        private float mMinorAxis;
        private float mMajorAxis;
        private float mWidth;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraphic;
        private Pen mPen;
        private const float SF = 20;

        public Deltoid()
        {
            this.mMinorAxis = 0.0f; this.mMajorAxis = 0.0f;
            this.mPerimeter = 0.0f; this.mArea = 0.0f;
            this.mWidth = 0.0f;
        }

        // Add validation to ensure the axes and width are valid
        public void readData(TextBox txtMajorAxis, TextBox txtMinorAxis, TextBox txtWidth)
        {
            try
            {
                float Major = float.Parse(txtMajorAxis.Text);
                float Minor = float.Parse(txtMinorAxis.Text);
                float Width = float.Parse(txtWidth.Text);

                if (Major <= 0 || Minor <= 0 || Width <= 0)
                {
                    MessageBox.Show("Los ejes y el ancho deben ser mayores a 0.", "Error");
                    this.mMajorAxis = 0.0f;
                    this.mMinorAxis = 0.0f;
                    this.mWidth = 0.0f;
                }
                else
                {
                    this.mMajorAxis = Major;
                    this.mMinorAxis = Minor;
                    this.mWidth = Width;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido. Asegúrese de ingresar números positivos.", "Error");
            }
        }

        public bool IsValid()
        {
            return this.mMajorAxis > 0 && this.mMinorAxis > 0 && this.mWidth > 0;
        }

        public void perimeterDeltoid()
        {
            float minorSide = 0.0f, majorSide = 0.0f;

            minorSide = (float)Math.Sqrt((this.mMinorAxis * this.mMinorAxis) + ((this.mWidth / 2) * (this.mWidth / 2)));

            majorSide = (float)Math.Sqrt(((this.mWidth / 2) * (this.mWidth / 2)) + (this.mMajorAxis * this.mMajorAxis));

            this.mPerimeter = 2 * (majorSide + minorSide);
        }

        public void areaDeltoid()
        {
            this.mArea = (this.mWidth * (this.mMinorAxis +  this.mMajorAxis))/2;
        }

        public void initData(TextBox txtMajorAxis, TextBox txtMinorAxis, TextBox txtWidth, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            this.mMinorAxis = 0.0f; this.mMajorAxis = 0.0f;
            this.mPerimeter = 0.0f; this.mArea = 0.0f;
            this.mWidth = 0.0f;

            txtArea.Clear();
            txtWidth.Clear();
            txtPerimeter.Clear();
            txtMajorAxis.Clear();
            txtMinorAxis.Clear();

            txtMajorAxis.Focus();
            picCanvas.Refresh();
        }

        public void showData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = this.mPerimeter.ToString();
            txtArea.Text = this.mArea.ToString();
        }

        public void plotShape(PictureBox picCanvas)
        {
            this.mGraphic = picCanvas.CreateGraphics();
            this.mPen = new Pen(Color.Blue, 3);

            PointF point1 = new PointF((this.mWidth / 2) * SF, 0);
            PointF point2 = new PointF(0, this.mMinorAxis * SF);
            PointF point3 = new PointF((this.mWidth / 2) * SF, (this.mMinorAxis + this.mMajorAxis) * SF);
            PointF point4 = new PointF(this.mWidth * SF, this.mMinorAxis * SF);

            PointF[] points = new PointF[]
                {point1, point2, point3, point4};

            mGraphic.DrawPolygon(mPen, points);
        }

        public void closeForm(Form form)
        {
            form.Close();
        }
    }
}
