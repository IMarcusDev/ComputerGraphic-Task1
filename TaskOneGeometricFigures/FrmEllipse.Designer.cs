namespace TaskOneGeometricFigures
{
    partial class FrmEllipse
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinorAxis = new System.Windows.Forms.TextBox();
            this.txtMajorAxis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(182, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 32);
            this.label4.TabIndex = 47;
            this.label4.Text = "Elipse";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReset.Location = new System.Drawing.Point(220, 252);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 35);
            this.btnReset.TabIndex = 46;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalcular.Location = new System.Drawing.Point(88, 252);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(125, 35);
            this.btnCalcular.TabIndex = 45;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtArea.Location = new System.Drawing.Point(220, 375);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(100, 35);
            this.txtArea.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(88, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 43;
            this.label3.Text = "Área:";
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPerimeter.Location = new System.Drawing.Point(220, 324);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.ReadOnly = true;
            this.txtPerimeter.Size = new System.Drawing.Size(100, 35);
            this.txtPerimeter.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(88, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 41;
            this.label2.Text = "Perímetro:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWidth.Location = new System.Drawing.Point(84, 166);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(77, 29);
            this.lblWidth.TabIndex = 40;
            this.lblWidth.Text = "Eje Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(87, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "Eje X:";
            // 
            // txtMinorAxis
            // 
            this.txtMinorAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMinorAxis.Location = new System.Drawing.Point(188, 160);
            this.txtMinorAxis.Name = "txtMinorAxis";
            this.txtMinorAxis.Size = new System.Drawing.Size(100, 35);
            this.txtMinorAxis.TabIndex = 38;
            // 
            // txtMajorAxis
            // 
            this.txtMajorAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMajorAxis.Location = new System.Drawing.Point(188, 112);
            this.txtMajorAxis.Name = "txtMajorAxis";
            this.txtMajorAxis.Size = new System.Drawing.Size(100, 35);
            this.txtMajorAxis.TabIndex = 37;
            // 
            // FrmEllipse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPerimeter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMinorAxis);
            this.Controls.Add(this.txtMajorAxis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEllipse";
            this.Text = "FrmEllipse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMinorAxis;
        private System.Windows.Forms.TextBox txtMajorAxis;
    }
}