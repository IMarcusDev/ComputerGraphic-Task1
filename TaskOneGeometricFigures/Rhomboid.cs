using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskOneGeometricFigures
{
    internal class Rhomboid
    {
        private float mHeight;
        private float mWidth;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraphic;
        private Pen mPen;
        private const float SF = 20;

        public Rhomboid()
        {
            this.mHeight = 0.0f; this.mWidth = 0.0f;
            this.mPerimeter = 0.0f;
            this.mArea = 0.0f;
        }

        public void readData(TextBox txtHeight, TextBox txtWidth)
        {
            try
            {
                float Height, Width;
                Height = float.Parse(txtHeight.Text);
                Width = float.Parse(txtWidth.Text);

                if (Height > 0.0f && Width > 0.0f)
                {
                    this.mHeight = Height;
                    this.mWidth = Width;
                }
            }
            catch 
            {
                MessageBox.Show("Ingreso invalido, las dimesiones deben ser numeros positivos y mayores que 0.", "Error");
            }
        }

        public void initData(TextBox txtHeight, TextBox txtWidth, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            this.mHeight = 0.0f; this.mWidth = 0.0f;
            this.mPerimeter = 0.0f; this.mArea = 0.0f;

            txtHeight.Clear();
            txtWidth.Clear();
            txtPerimeter.Clear();
            txtArea.Clear();

            txtHeight.Focus();
            picCanvas.Refresh();
        }

        public void perimeterRhomboid()
        {
            this.mPerimeter = 2 * (this.mHeight + this.mWidth);
        }

        public void areaRhomboid()
        {
            this.mArea = this.mHeight * this.mWidth;
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

            PointF point1 = new PointF((this.mWidth / 4) * SF, 0);
            PointF point2 = new PointF(this.mWidth * SF, 0);
            PointF point3 = new PointF(this.mWidth * SF, this.mHeight * SF);
            PointF point4 = new PointF(0, this.mHeight * SF);

            PointF[] points = new PointF[] { point1, point2, point3, point4 };

            this.mGraphic.DrawPolygon(mPen, points);
        }

        public void closeForm(Form form)
        {
            form.Close();
        }
    }
}
