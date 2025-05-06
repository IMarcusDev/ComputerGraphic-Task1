using System;
using System.Drawing;
using System.Windows.Forms;

namespace TaskOneGeometricFigures
{
    internal class Star
    {
        private float mCenterX;
        private float mCenterY;
        private float mOuterRadius;
        private float mInnerRadius;
        private Graphics mGraphic;
        private Pen mPen;
        private const float SF = 20;

        public Star()
        {
            this.mCenterX = 0.0f;
            this.mCenterY = 0.0f;
            this.mOuterRadius = 0.0f;
            this.mInnerRadius = 0.0f;
        }

        public void readData(TextBox txtOuterRadius, TextBox txtInnerRadius)
        {
            try
            {
                this.mOuterRadius = float.Parse(txtOuterRadius.Text);
                this.mInnerRadius = float.Parse(txtInnerRadius.Text);

                if (!IsValid())
                {
                    MessageBox.Show("El radio exterior debe ser mayor que el radio interior, y ambos deben ser mayores a 0.", "Error");
                    this.mOuterRadius = 0.0f;
                    this.mInnerRadius = 0.0f;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso inválido. Asegúrese de ingresar números positivos.", "Error");
            }
        }

        public void plotShape(PictureBox picCanvas)
        {
            if (!IsValid())
            {
                MessageBox.Show("Dimensiones inválidas. No se puede dibujar la estrella.", "Error");
                return;
            }

            this.mGraphic = picCanvas.CreateGraphics();
            this.mPen = new Pen(Color.Blue, 2);

            float centerX = picCanvas.Width / 2.0f;
            float centerY = picCanvas.Height / 2.0f;

            PointF[] points = new PointF[10];
            double angle = -Math.PI / 2;
            double step = Math.PI / 5;

            for (int i = 0; i < 10; i++)
            {
                float radius = (i % 2 == 0) ? this.mOuterRadius : this.mInnerRadius;
                points[i] = new PointF(
                    centerX + radius * (float)Math.Cos(angle) * SF,
                    centerY + radius * (float)Math.Sin(angle) * SF
                );
                angle += step;
            }

            this.mGraphic.DrawPolygon(mPen, points);
        }

        public void perimeterStar(TextBox txtPerimeter)
        {
            double angle = -Math.PI / 2;
            double step = Math.PI / 5;
            PointF[] points = new PointF[10];

            for (int i = 0; i < 10; i++)
            {
                float radius = (i % 2 == 0) ? this.mOuterRadius : this.mInnerRadius;
                points[i] = new PointF(
                    this.mCenterX + radius * (float)Math.Cos(angle),
                    this.mCenterY + radius * (float)Math.Sin(angle)
                );
                angle += step;
            }

            float perimeter = 0.0f;
            for (int i = 0; i < 10; i++)
            {
                PointF p1 = points[i];
                PointF p2 = points[(i + 1) % 10];
                perimeter += (float)Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
            }

            txtPerimeter.Text = perimeter.ToString();
        }

        public void areaStar(TextBox txtArea)
        {
            PointF[] points = new PointF[10];
            double angle = -Math.PI / 2;
            double step = Math.PI / 5;

            for (int i = 0; i < 10; i++)
            {
                float radius = (i % 2 == 0) ? this.mOuterRadius : this.mInnerRadius;
                points[i] = new PointF(
                    this.mCenterX + radius * (float)Math.Cos(angle),
                    this.mCenterY + radius * (float)Math.Sin(angle)
                );
                angle += step;
            }

            float area = 0.0f;
            for (int i = 0; i < 10; i++)
            {
                PointF p1 = points[i];
                PointF p2 = points[(i + 1) % 10];
                area += (p1.X * p2.Y) - (p2.X * p1.Y);
            }
            area = Math.Abs(area) / 2.0f;

            txtArea.Text = area.ToString();
        }

        public void showData(TextBox txtPerimeter, TextBox txtArea)
        {
            perimeterStar(txtPerimeter);
            areaStar(txtArea);
        }

        public void initData(TextBox txtOuterRadius, TextBox txtInnerRadius, PictureBox picCanvas)
        {
            this.mCenterX = 0.0f;
            this.mCenterY = 0.0f;
            this.mOuterRadius = 0.0f;
            this.mInnerRadius = 0.0f;

            txtOuterRadius.Clear();
            txtInnerRadius.Clear();

            txtOuterRadius.Focus();
            picCanvas.Refresh();
        }

        public void closeForm(Form form)
        {
            form.Close();
        }

        public bool IsValid()
        {
            return this.mOuterRadius > 0 && this.mInnerRadius > 0 && this.mInnerRadius < this.mOuterRadius;
        }
    }
}
