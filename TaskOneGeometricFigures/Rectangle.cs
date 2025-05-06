using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskOneGeometricFigures
{
    internal class Rectangle
    {
        private float mWidth;
        private float mHeight;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public Rectangle()
        {
            this.mWidth = 0.0f; mHeight = 0.0f;
            this.mPerimeter = 0.0f; mArea = 0.0f;
        }

        // Add validation to ensure the rectangle's dimensions are valid
        public void readData(TextBox txtWidth, TextBox txtHeight)
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
                else if (this.mWidth == this.mHeight)
                {
                    MessageBox.Show("El ancho y la altura son iguales, lo que forma un cuadrado. Por favor, ingrese valores diferentes para formar un rectángulo.", "Advertencia");
                    this.mWidth = 0.0f;
                    this.mHeight = 0.0f;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido. Asegúrese de ingresar números positivos.", "Error");
            }
        }

        public void perimeterRectangle()
        {
            this.mPerimeter = 2 * (mWidth + mHeight);
        }

        public void areaRectangle()
        {
            this.mArea = mWidth * mHeight;
        }

        public void showData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtArea.Text = mArea.ToString();
            txtPerimeter.Text = mPerimeter.ToString();
        }

        public void initData(TextBox txtWidth, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            this.mWidth = 0.0f; this.mHeight = 0.0f;
            this.mPerimeter = 0.0f; this.mArea = 0.0f;

            txtWidth.Text = ""; txtArea.Text = "";
            txtHeight.Text = ""; txtPerimeter.Text = "";

            txtWidth.Focus();
            picCanvas.Refresh();
        }

        public void plotShape(PictureBox picCanvas)
        {
            if (this.mWidth <= 0 || this.mHeight <= 0)
            {
                MessageBox.Show("Dimensiones inválidas. No se puede dibujar el rectángulo.", "Error");
                return;
            }

            this.mGraph = picCanvas.CreateGraphics();
            this.mPen = new Pen(Color.Blue, 3);
            mGraph.DrawRectangle(mPen, 0, 0, mWidth * SF, mHeight * SF);
        }

        public void closeForm(Form form)
        {
            form.Close();
        }
    }
}
