namespace TaskOneGeometricFigures
{
    partial class FrmDiamond
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
            this.txtMinorDiag = new System.Windows.Forms.TextBox();
            this.txtMajorDiag = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(151, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 41);
            this.label4.TabIndex = 36;
            this.label4.Text = "Diamond";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Tan;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReset.Location = new System.Drawing.Point(226, 242);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 54);
            this.btnReset.TabIndex = 35;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Tan;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalcular.Location = new System.Drawing.Point(94, 242);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(125, 54);
            this.btnCalcular.TabIndex = 34;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtArea
            // 
            this.txtArea.BackColor = System.Drawing.Color.OldLace;
            this.txtArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtArea.Location = new System.Drawing.Point(226, 377);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(140, 35);
            this.txtArea.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(94, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "Área:";
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.BackColor = System.Drawing.Color.OldLace;
            this.txtPerimeter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPerimeter.Location = new System.Drawing.Point(226, 326);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.ReadOnly = true;
            this.txtPerimeter.Size = new System.Drawing.Size(140, 35);
            this.txtPerimeter.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(94, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 30;
            this.label2.Text = "Perímetro:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWidth.Location = new System.Drawing.Point(55, 167);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(190, 29);
            this.lblWidth.TabIndex = 29;
            this.lblWidth.Text = "Diagonal Menor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(58, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Diagonal Mayor:";
            // 
            // txtMinorDiag
            // 
            this.txtMinorDiag.BackColor = System.Drawing.Color.OldLace;
            this.txtMinorDiag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMinorDiag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMinorDiag.Location = new System.Drawing.Point(251, 167);
            this.txtMinorDiag.Name = "txtMinorDiag";
            this.txtMinorDiag.Size = new System.Drawing.Size(140, 35);
            this.txtMinorDiag.TabIndex = 27;
            // 
            // txtMajorDiag
            // 
            this.txtMajorDiag.BackColor = System.Drawing.Color.OldLace;
            this.txtMajorDiag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMajorDiag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMajorDiag.Location = new System.Drawing.Point(251, 113);
            this.txtMajorDiag.Name = "txtMajorDiag";
            this.txtMajorDiag.Size = new System.Drawing.Size(140, 35);
            this.txtMajorDiag.TabIndex = 26;
            // 
            // FrmDiamond
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
            this.Controls.Add(this.txtMinorDiag);
            this.Controls.Add(this.txtMajorDiag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDiamond";
            this.Text = "FrmDiamond";
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
        private System.Windows.Forms.TextBox txtMinorDiag;
        private System.Windows.Forms.TextBox txtMajorDiag;
    }
}