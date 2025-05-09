﻿using System;
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
            this.mDiagA = 0.0f; this.mDiagB = 0.0f;
            this.mPerimeter = 0.0f; this.mArea = 0.0f;
            this.mHeight = 0.0f;
        }

        public void readData(TextBox txtSideA, TextBox txtSideB, TextBox txtSideC, TextBox txtSideD, TextBox txtHeight)
        {
            try
            {
                float SideA = float.Parse(txtSideA.Text);
                float SideB = float.Parse(txtSideB.Text);
                float SideC = float.Parse(txtSideC.Text);
                float SideD = float.Parse(txtSideD.Text);
                float Height = float.Parse(txtHeight.Text);

                if (SideA <= 0 || SideB <= 0 || SideC <= 0 || SideD <= 0 || Height <= 0)
                {
                    MessageBox.Show("Todos los valores deben ser mayores a 0.", "Error");
                    return;
                }

                this.mSideA = SideA;
                this.mSideB = SideB;
                this.mSideC = SideC;
                this.mSideD = SideD;
                this.mHeight = Height;
            }
            catch
            {
                MessageBox.Show("Ingreso inválido, solo números positivos mayores a 0.", "Error");
            }
        }

        public void perimeterTrapezoid()
        {
            this.mPerimeter = this.mSideA + this.mSideB + this.mSideC + this.mSideD;
        }

        public void areaTrapezoid()
        {
            this.mArea = ((this.mSideA + this.mSideB) / 2) * this.mHeight;
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

            PointF[] points = new PointF[]
            {
                new PointF(picCanvas.Width / 5.5f - this.mSideA, picCanvas.Height - picCanvas.Height / 4f + this.mSideA),
                new PointF(picCanvas.Width - picCanvas.Width / 4f + this.mSideB, picCanvas.Height - picCanvas.Height / 3f + this.mSideB),
                new PointF(picCanvas.Width - picCanvas.Width / 6f + this.mSideC, picCanvas.Height / 3f - this.mSideC),
                new PointF(picCanvas.Width / 4f - this.mSideD, picCanvas.Height / 2f - this.mSideD)
            };

            this.mGraphic.DrawPolygon(this.mPen, points);
        }

        public void initData(TextBox txtSideA, TextBox txtSideB, TextBox txtSideC, TextBox txtSideD, TextBox txtHeight, PictureBox picCanvas)
        {
            this.mSideA = 0.0f; this.mSideB = 0.0f;
            this.mSideC = 0.0f; this.mSideD = 0.0f;
            this.mPerimeter = 0.0f; this.mArea = 0.0f;
            this.mHeight = 0.0f;

            txtSideA.Clear();
            txtSideB.Clear();
            txtSideC.Clear();
            txtSideD.Clear();
            txtHeight.Clear();

            txtSideA.Focus();
            picCanvas.Refresh();
        }

        public bool isValid()
        {
            if (this.mSideA <= 0 || this.mSideB <= 0 || this.mSideC <= 0 || this.mSideD <= 0 || this.mHeight <= 0)
            {
                return false;
            }

            float minBase = Math.Min(this.mSideA, this.mSideB);
            float maxBase = Math.Max(this.mSideC, this.mSideD);
            if (this.mHeight <= Math.Min(this.mDiagA, this.mDiagB) || this.mHeight <= 0 || maxBase <= minBase)
            {
                return false;
            }

            return true;
        }
    }
}
