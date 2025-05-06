using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskOneGeometricFigures
{
    internal class Triangle
    {
        private float mWidth;
        private float mHeight;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public Triangle()
        {
            this.mWidth = 0.0f; mHeight = 0.0f;
            this.mPerimeter = 0.0f; mArea = 0.0f;
        }

        public void ReadData(TextBox txtWidth, TextBox txtHeight)
        {
            try
            {
                this.mWidth = float.Parse(txtWidth.Text);
                this.mHeight = float.Parse(txtHeight.Text);

                if (this.mWidth <= 0 || this.mHeight <= 0)
                {
                    MessageBox.Show("El ancho y la altura deben ser mayores a 0.", "Error");
                    this.mWidth = 0.0f;
                    this.mHeight = 0.0f;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso inválido. Asegúrese de ingresar números positivos.", "Error");
            }
        }

        public void PerimeterTriangle()
        {
            this.mPerimeter = mWidth + 2 * mHeight;
        }  

        public void AreaTriangle()
        {
            this.mArea = (mWidth * mHeight) / 2;
        }

        public void ShowData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtArea.Text = mArea.ToString();
            txtPerimeter.Text = mPerimeter.ToString();
        }

        public void InitData(TextBox txtWidth, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            this.mWidth = 0.0f; this.mHeight = 0.0f;
            this.mPerimeter = 0.0f; this.mArea = 0.0f;

            txtWidth.Text = ""; txtArea.Text = "";
            txtHeight.Text = ""; txtPerimeter.Text = "";

            txtWidth.Focus();
            picCanvas.Refresh();
        }

        public void PlotShape(PictureBox picCanvas)
        {
            this.mGraph = picCanvas.CreateGraphics();
            this.mPen = new Pen(Color.Blue, 3);
            PointF point1 = new PointF(0, mHeight * SF);
            PointF point2 = new PointF(mWidth * SF, mHeight * SF);
            PointF point3 = new PointF((mWidth * SF) / 2, 0);

            PointF[] trianglePoints = new PointF[] 
            { point1, point2, point3};

            mGraph.DrawPolygon(mPen, trianglePoints);
        }
    }
}
