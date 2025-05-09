﻿namespace TaskOneGeometricFigures
{
    partial class FrmTriangle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHeight
            // 
            this.txtHeight.BackColor = System.Drawing.Color.OldLace;
            this.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHeight.Location = new System.Drawing.Point(215, 104);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(128, 35);
            this.txtHeight.TabIndex = 0;
            // 
            // txtWidth
            // 
            this.txtWidth.BackColor = System.Drawing.Color.OldLace;
            this.txtWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtWidth.Location = new System.Drawing.Point(215, 158);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(128, 35);
            this.txtWidth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(123, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alto:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWidth.Location = new System.Drawing.Point(123, 158);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(86, 29);
            this.lblWidth.TabIndex = 3;
            this.lblWidth.Text = "Ancho:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(128, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Perímetro:";
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.BackColor = System.Drawing.Color.OldLace;
            this.txtPerimeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPerimeter.Location = new System.Drawing.Point(260, 341);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.ReadOnly = true;
            this.txtPerimeter.Size = new System.Drawing.Size(128, 35);
            this.txtPerimeter.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(128, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Área:";
            // 
            // txtArea
            // 
            this.txtArea.BackColor = System.Drawing.Color.OldLace;
            this.txtArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtArea.Location = new System.Drawing.Point(260, 392);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(128, 35);
            this.txtArea.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Tan;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalcular.Location = new System.Drawing.Point(128, 220);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(125, 64);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Tan;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReset.Location = new System.Drawing.Point(260, 220);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 64);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(163, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 41);
            this.label4.TabIndex = 12;
            this.label4.Text = "Triángulo";
            // 
            // FrmTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(490, 514);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPerimeter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtHeight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTriangle";
            this.Text = "FrmTriangle";
            this.Load += new System.EventHandler(this.FrmTriangle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label4;
    }
}