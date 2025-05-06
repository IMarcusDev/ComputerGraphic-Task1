namespace TaskOneGeometricFigures
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTriangle = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSquare = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStar = new System.Windows.Forms.ToolStripMenuItem();
            this.irregularPolygonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRhomboid = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTrapeze = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTrapezoid = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeltoid = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDiamond = new System.Windows.Forms.ToolStripMenuItem();
            this.curvedFiguresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCircle = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEllipse = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSemicircle = new System.Windows.Forms.ToolStripMenuItem();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 36);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(92, 32);
            this.sToolStripMenuItem.Text = "s";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaShell;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1380, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polygonsToolStripMenuItem,
            this.irregularPolygonsToolStripMenuItem,
            this.curvedFiguresToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(93, 36);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // polygonsToolStripMenuItem
            // 
            this.polygonsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTriangle,
            this.btnSquare,
            this.btnStar});
            this.polygonsToolStripMenuItem.Name = "polygonsToolStripMenuItem";
            this.polygonsToolStripMenuItem.Size = new System.Drawing.Size(310, 40);
            this.polygonsToolStripMenuItem.Text = "Regular Polygons";
            // 
            // btnTriangle
            // 
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(202, 40);
            this.btnTriangle.Text = "Triangle";
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(202, 40);
            this.btnSquare.Text = "Square";
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnStar
            // 
            this.btnStar.Name = "btnStar";
            this.btnStar.Size = new System.Drawing.Size(202, 40);
            this.btnStar.Text = "Star";
            this.btnStar.Click += new System.EventHandler(this.btnStar_Click);
            // 
            // irregularPolygonsToolStripMenuItem
            // 
            this.irregularPolygonsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRectangle,
            this.btnRhomboid,
            this.btnTrapeze,
            this.btnTrapezoid,
            this.btnDeltoid,
            this.btnDiamond});
            this.irregularPolygonsToolStripMenuItem.Name = "irregularPolygonsToolStripMenuItem";
            this.irregularPolygonsToolStripMenuItem.Size = new System.Drawing.Size(310, 40);
            this.irregularPolygonsToolStripMenuItem.Text = "Irregular Polygons";
            // 
            // btnRectangle
            // 
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(229, 40);
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnRhomboid
            // 
            this.btnRhomboid.Name = "btnRhomboid";
            this.btnRhomboid.Size = new System.Drawing.Size(229, 40);
            this.btnRhomboid.Text = "Rhomboid";
            this.btnRhomboid.Click += new System.EventHandler(this.btnRhomboid_Click);
            // 
            // btnTrapeze
            // 
            this.btnTrapeze.Name = "btnTrapeze";
            this.btnTrapeze.Size = new System.Drawing.Size(229, 40);
            this.btnTrapeze.Text = "Trapeze";
            this.btnTrapeze.Click += new System.EventHandler(this.btnTrapeze_Click);
            // 
            // btnTrapezoid
            // 
            this.btnTrapezoid.Name = "btnTrapezoid";
            this.btnTrapezoid.Size = new System.Drawing.Size(229, 40);
            this.btnTrapezoid.Text = "Trapezoid";
            this.btnTrapezoid.Click += new System.EventHandler(this.btnTrapezoid_Click);
            // 
            // btnDeltoid
            // 
            this.btnDeltoid.Name = "btnDeltoid";
            this.btnDeltoid.Size = new System.Drawing.Size(229, 40);
            this.btnDeltoid.Text = "Deltoid";
            this.btnDeltoid.Click += new System.EventHandler(this.btnDeltoid_Click);
            // 
            // btnDiamond
            // 
            this.btnDiamond.Name = "btnDiamond";
            this.btnDiamond.Size = new System.Drawing.Size(229, 40);
            this.btnDiamond.Text = "Diamond";
            this.btnDiamond.Click += new System.EventHandler(this.btnDiamond_Click);
            // 
            // curvedFiguresToolStripMenuItem
            // 
            this.curvedFiguresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCircle,
            this.btnEllipse,
            this.btnSemicircle});
            this.curvedFiguresToolStripMenuItem.Name = "curvedFiguresToolStripMenuItem";
            this.curvedFiguresToolStripMenuItem.Size = new System.Drawing.Size(310, 40);
            this.curvedFiguresToolStripMenuItem.Text = "Curved Figures";
            // 
            // btnCircle
            // 
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(226, 40);
            this.btnCircle.Text = "Circle";
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(226, 40);
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnSemicircle
            // 
            this.btnSemicircle.Name = "btnSemicircle";
            this.btnSemicircle.Size = new System.Drawing.Size(226, 40);
            this.btnSemicircle.Text = "Semicircle";
            this.btnSemicircle.Click += new System.EventHandler(this.btnSemicircle_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.Info;
            this.picCanvas.Location = new System.Drawing.Point(667, 54);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(690, 574);
            this.picCanvas.TabIndex = 2;
            this.picCanvas.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(12, 54);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(619, 574);
            this.panelContainer.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1380, 679);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnTriangle;
        private System.Windows.Forms.ToolStripMenuItem btnSquare;
        private System.Windows.Forms.ToolStripMenuItem btnStar;
        private System.Windows.Forms.ToolStripMenuItem irregularPolygonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnRectangle;
        private System.Windows.Forms.ToolStripMenuItem btnRhomboid;
        private System.Windows.Forms.ToolStripMenuItem btnTrapeze;
        private System.Windows.Forms.ToolStripMenuItem btnTrapezoid;
        private System.Windows.Forms.ToolStripMenuItem btnDeltoid;
        private System.Windows.Forms.ToolStripMenuItem btnDiamond;
        private System.Windows.Forms.ToolStripMenuItem curvedFiguresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCircle;
        private System.Windows.Forms.ToolStripMenuItem btnEllipse;
        private System.Windows.Forms.ToolStripMenuItem btnSemicircle;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Panel panelContainer;
    }
}