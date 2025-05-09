﻿using System;
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
        private float mAngle;
        private Graphics mGraphic;
        private Pen mPen;
        private const float SF = 20;

        public Rhomboid()
        {
            this.mHeight = 0.0f; this.mWidth = 0.0f;
            this.mPerimeter = 0.0f;
            this.mArea = 0.0f;
            this.mAngle = 0.0f;
        }

        public void readData(TextBox txtHeight, TextBox txtWidth, TextBox txtAngle)
        {
            try
            {
                float Height = float.Parse(txtHeight.Text);
                float Width = float.Parse(txtWidth.Text);
                float Angle = float.Parse(txtAngle.Text);

                if (Height <= 0 || Width <= 0 || Angle <= 0 || Angle >= 90)
                {
                    MessageBox.Show("La altura, el ancho y el ángulo deben ser mayores a 0, y el ángulo menor a 90 grados.", "Error");
                    this.mHeight = 0.0f;
                    this.mWidth = 0.0f;
                    this.mAngle = 0.0f;
                }
                else
                {
                    this.mHeight = Height;
                    this.mWidth = Width;
                    this.mAngle = Angle;
                }
            }
            catch
            {
                MessageBox.Show("Ingreso inválido. Asegúrese de ingresar números positivos.", "Error");
            }
        }

        public void initData(TextBox txtHeight, TextBox txtWidth, TextBox txtAngle, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            this.mHeight = 0.0f; this.mWidth = 0.0f;
            this.mPerimeter = 0.0f; this.mArea = 0.0f;
            this.mAngle = 0.0f;

            txtHeight.Clear();
            txtWidth.Clear();
            txtAngle.Clear();
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
            if (this.mHeight <= 0 || this.mWidth <= 0 || this.mAngle <= 0 || this.mAngle >= 90)
            {
                MessageBox.Show("Dimensiones o ángulo inválidos. No se puede dibujar el romboide.", "Error");
                return;
            }

            this.mGraphic = picCanvas.CreateGraphics();
            this.mPen = new Pen(Color.Blue, 3);

            float centerX = picCanvas.Width / 2.0f;
            float centerY = picCanvas.Height / 2.0f;

            float offsetX = centerX - (this.mWidth * SF) / 2;
            float offsetY = centerY - (this.mHeight * SF) / 2;

            float angleOffset = (float)(Math.Tan(this.mAngle * Math.PI / 180) * this.mHeight * SF);

            PointF point1 = new PointF(offsetX, offsetY + this.mHeight * SF);
            PointF point2 = new PointF(offsetX + this.mWidth * SF, offsetY + this.mHeight * SF);
            PointF point3 = new PointF(offsetX + this.mWidth * SF - angleOffset, offsetY);
            PointF point4 = new PointF(offsetX - angleOffset, offsetY);

            PointF[] points = new PointF[] { point1, point2, point3, point4 };

            this.mGraphic.DrawPolygon(this.mPen, points);
        }
    }
}
