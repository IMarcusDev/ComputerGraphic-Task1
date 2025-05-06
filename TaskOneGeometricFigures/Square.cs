using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskOneGeometricFigures
{
    internal class Square
    {
        private float mWidth;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public Square()
        {
            this.mWidth = 0.0f;
            this.mPerimeter = 0.0f; mArea = 0.0f;
        }

        public void readData(TextBox txtWidth)
        {
            try
            {
                this.mWidth = float.Parse(txtWidth.Text);

                if (this.mWidth <= 0)
                {
                    MessageBox.Show("El lado del cuadrado debe ser mayor a 0.", "Error");
                    this.mWidth = 0.0f;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso no válido. Asegúrese de ingresar un número positivo.", "Error");
            }
        }

        public void perimeterSquare()
        {
            this.mPerimeter = 4 * mWidth;
        }

        public void areaSquare()
        {
            this.mArea = mWidth * mWidth;
        }

        public void showData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtArea.Text = mArea.ToString();
            txtPerimeter.Text = mPerimeter.ToString();
        }

        public void initData(TextBox txtWidth, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            this.mWidth = 0.0f;
            this.mPerimeter = 0.0f; this.mArea = 0.0f;

            txtWidth.Text = ""; txtArea.Text = "";
            txtPerimeter.Text = "";

            txtWidth.Focus();
            picCanvas.Refresh();
        }

        public void plotShape(PictureBox picCanvas)
        {
            if (this.mWidth <= 0)
            {
                MessageBox.Show("Dimensiones inválidas. No se puede dibujar el cuadrado.", "Error");
                return;
            }

            this.mGraph = picCanvas.CreateGraphics();
            this.mPen = new Pen(Color.Blue, 3);
            mGraph.DrawRectangle(mPen, 0, 0, mWidth * SF, mWidth * SF);
        }

        public void closeForm(Form form)
        {
            form.Close();
        }
    }
}
