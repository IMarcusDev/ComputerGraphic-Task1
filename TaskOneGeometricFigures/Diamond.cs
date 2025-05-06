using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskOneGeometricFigures
{
    internal class Diamond
    {
        private float mMajorDiag;
        private float mMinorDiag;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraphic;
        private Pen mPen;
        private const float SF = 20;

        public Diamond()
        {
            this.mMajorDiag = 0.0f; this.mPerimeter = 0.0f;
            this.mArea = 0.0f; this.mMinorDiag = 0.0f;
        }

        public void initData(TextBox txtMajorDiag, TextBox txtMinorDiag, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            this.mMajorDiag = 0.0f; this.mPerimeter = 0.0f;
            this.mArea = 0.0f; this.mMinorDiag = 0.0f;

            txtArea.Clear();
            txtMajorDiag.Clear();
            txtMinorDiag.Clear();
            txtPerimeter.Clear();

            txtMajorDiag.Focus();
            picCanvas.Refresh();
        }

        public void readData(TextBox txtMajorDiag, TextBox txtMinorDiag)
        {
            try
            {
                float Major = float.Parse(txtMajorDiag.Text);
                float Minor = float.Parse(txtMinorDiag.Text);

                if (Major <= 0 || Minor <= 0)
                {
                    MessageBox.Show("Las diagonales deben ser mayores a 0.", "Error");
                    this.mMajorDiag = 0.0f;
                    this.mMinorDiag = 0.0f;
                }
                else
                {
                    this.mMajorDiag = Major;
                    this.mMinorDiag = Minor;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido. Asegúrese de ingresar números positivos.", "Error");
            }
        }

        public void perimeterDiamond()
        {
            this.mPerimeter = 4 * ((float)Math.Sqrt(Math.Pow((this.mMajorDiag/2), 2) + Math.Pow((this.mMinorDiag / 2), 2)));
        }

        public void areaDiamond()
        {
            this.mArea = (this.mMajorDiag * this.mMinorDiag) / 2;
        }

        public void showData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtArea.Text = this.mArea.ToString();
            txtPerimeter.Text = this.mPerimeter.ToString();
        }

        public void plotShape(PictureBox picCanvas)
        {
            this.mGraphic = picCanvas.CreateGraphics();
            this.mPen = new Pen(Color.Blue, 3);

            PointF point1 = new PointF((this.mMinorDiag / 2) * SF, 0);
            PointF point2 = new PointF(0, (this.mMajorDiag / 2) * SF);
            PointF point3 = new PointF((this.mMinorDiag / 2) * SF, this.mMajorDiag * SF);
            PointF point4 = new PointF(this.mMinorDiag * SF, (this.mMajorDiag / 2) * SF);

            PointF[] points = new PointF[] { point1, point2, point3, point4 };

            mGraphic.DrawPolygon(mPen, points);
        }

        public void closeForm(Form form)
        {
            form.Close();
        }

        public bool IsValid()
        {
            return this.mMajorDiag > 0 && this.mMinorDiag > 0;
        }
    }
}
