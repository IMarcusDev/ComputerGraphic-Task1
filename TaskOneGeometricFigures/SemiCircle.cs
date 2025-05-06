using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskOneGeometricFigures
{
    internal class SemiCircle
    {
        private float mRadius;
        private float mAngle;
        private float mPerimeter;
        private float mArea;
        private const float SF = 20;
        private Graphics mGraph;
        private Pen mPen;

        public SemiCircle()
        {
            this.mRadius = 0.0f; this.mAngle = 180;
            this.mPerimeter = 0.0f; this.mArea = 0.0f;
        }

        public void readData(TextBox txtRadius)
        {
            try
            {
                this.mRadius = float.Parse(txtRadius.Text);

                if (this.mRadius <= 0)
                {
                    MessageBox.Show("El radio debe ser mayor a 0.", "Error");
                    this.mRadius = 0.0f;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso inválido. Asegúrese de ingresar un número positivo.", "Error");
            }
        }

        public void perimeterCircle()
        {
            this.mPerimeter = (float)Math.PI * this.mRadius;
        }

        public void areaCircle()
        {
            this.mArea = ((float)Math.PI * this.mRadius * this.mRadius)/2;
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
            if (this.mRadius <= 0)
            {
                MessageBox.Show("Dimensiones inválidas. No se puede dibujar el semicírculo.", "Error");
                return;
            }

            this.mGraph = picCanvas.CreateGraphics();
            this.mPen = new Pen(Color.Blue, 3);

            float diameter = this.mRadius * 2 * SF;

            this.mGraph.DrawPie(mPen, 0, 0, diameter, diameter, 0, 180);
        }
    }
}
