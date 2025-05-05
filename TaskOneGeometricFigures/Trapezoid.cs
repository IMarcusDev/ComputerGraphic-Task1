using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskOneGeometricFigures
{
    internal class Trapezoid
    {
        private float mSideA;
        private float mSideB;
        private float mSideC;
        private float mSideD;
        private float mDiagA;
        private float mDiagB;
        private float mHeight;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraphic;
        private Pen mPen;
        private const float SF = 20;

        public Trapezoid()
        {
            this.mSideA = 0.0f; this.mSideB = 0.0f;
            this.mSideC = 0.0f; this.mSideD = 0.0f;
            this.mDiagA = 0.0f;this.mDiagB = 0.0f;
            this.mPerimeter = 0.0f; this.mArea = 0.0f;
            this.mHeight = 0.0f;
        }

        public void readData(TextBox txtSideA, TextBox txtSideB, TextBox txtDiagA, TextBox txtDiagB, TextBox txtHeight)
        {
            try
            {
                float SideA = float.Parse(txtSideA.Text);
                float SideB = float.Parse(txtSideB.Text);
                float DiagA = float.Parse(txtDiagA.Text);
                float DiagB = float.Parse(txtDiagB.Text);
                float Height = float.Parse(txtHeight.Text);

                if (SideA <= 0 || SideB <= 0 || DiagA <= 0 || DiagB <= 0 || Height <= 0)
                {
                    MessageBox.Show("Todos los valores deben ser mayores a 0.", "Error");
                    return;
                }

                if (SideB <= SideA)
                {
                    MessageBox.Show("La base mayor (SideB) debe ser mayor que la base menor (SideA).", "Error");
                    return;
                }

                if (DiagA <= Height || DiagB <= Height)
                {
                    MessageBox.Show("Las diagonales deben ser mayores que la altura.", "Error");
                    return;
                }

                this.mSideA = SideA;
                this.mSideB = SideB;
                this.mDiagA = DiagA;
                this.mDiagB = DiagB;
                this.mHeight = Height;
            }
            catch
            {
                MessageBox.Show("Ingreso inválido, solo números positivos mayores a 0.", "Error");
            }
        }

        public void perimeterTrapezoid()
        {
            float j = (float)Math.Sqrt(Math.Pow(this.mDiagB, 2) - Math.Pow(this.mHeight, 2));
            float k = this.mSideB - j;
            if (k > 0.0f)
            {
                this.mSideC = (float)Math.Sqrt(Math.Pow(k, 2) + Math.Pow(this.mHeight, 2));
            }

            float B = (float)Math.Acos((Math.Pow(this.mDiagB, 2) + Math.Pow(this.mSideB, 2) - Math.Pow(this.mSideC, 2)) / (2 * this.mDiagB * this.mSideB));

            float A = (float)Math.Acos((Math.Pow(this.mSideA, 2) + Math.Pow(this.mSideB, 2) - Math.Pow(this.mDiagA, 2)) / (2 * this.mSideA * this.mSideB));

            float T = A - B;

            this.mSideD = (float)Math.Sqrt(Math.Pow(this.mDiagB, 2) + Math.Pow(this.mSideA, 2) - 2 * this.mDiagB * this.mSideA * Math.Cos(T));

            this.mPerimeter = this.mSideA + this.mSideB + this.mSideC + this.mSideD;
        }

        public void areaTrapezoid()
        {
            float b1 = 0.0f, b2 = 0.0f, h1 = 0.0f, h2 = 0.0f;

            b1 = (float)Math.Acos((Math.Pow(this.mSideC,2) + Math.Pow(this.mDiagA,2) - Math.Pow(this.mSideD,2)) / (2 * this.mSideC * this.mDiagA));

            h1 = this.mSideC * (float)Math.Sin(b1);

            b2 = (float)Math.Acos((Math.Pow(this.mSideB,2) + Math.Pow(this.mDiagA,2) - Math.Pow(this.mSideA,2)) / (2 * this.mSideB * this.mDiagA));

            h2 = this.mSideB * (float)Math.Sin(b2);

            this.mArea = (this.mDiagA / 2) * (h1 + h2);
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

            float i = (float)Math.Sqrt(Math.Pow(this.mDiagA, 2) - Math.Pow(this.mSideA, 2));

            PointF point1 = new PointF(0, this.mHeight * SF);
            PointF point2 = new PointF(this.mSideB * SF, this.mHeight * SF);
            PointF point3 = new PointF((float)Math.Sqrt(Math.Pow(this.mDiagB,2) - Math.Pow(this.mHeight, 2)) * SF, 0);
            PointF point4 = new PointF((this.mSideB - i) * SF, (this.mHeight - this.mSideA) * SF);

            PointF[] points = new PointF[] { point1, point2, point3, point4};

            this.mGraphic.DrawPolygon(mPen, points);
        }

        public void initData(TextBox txtSideA, TextBox txtSideB, TextBox txtDiagA, TextBox txtDiagB, TextBox txtHeight, PictureBox picCanvas)
        {
            this.mSideA = 0.0f; this.mSideB = 0.0f;
            this.mSideC = 0.0f; this.mSideD = 0.0f;
            this.mDiagA = 0.0f; this.mDiagB = 0.0f;
            this.mPerimeter = 0.0f; this.mArea = 0.0f;
            this.mHeight = 0.0f;

            txtSideA.Clear();
            txtSideB.Clear();
            txtDiagA.Clear();
            txtDiagB.Clear();
            txtHeight.Clear();

            txtSideA.Focus();
            picCanvas.Refresh();
        }

        public void closeForm(Form form)
        {
            form.Close();
        }
    }
}
