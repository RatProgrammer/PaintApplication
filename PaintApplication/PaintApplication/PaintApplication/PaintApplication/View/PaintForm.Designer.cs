using System;
using System.Windows.Forms;

namespace PaintApplication.View
{
    partial class PaintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintForm));
            this.btnPencil = new System.Windows.Forms.Button();
            this.btnRubber = new System.Windows.Forms.Button();
            this.btnBucket = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.sizeTrackBar = new System.Windows.Forms.TrackBar();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Right90 = new System.Windows.Forms.ToolStripMenuItem();
            this.Left90 = new System.Windows.Forms.ToolStripMenuItem();
            this.right90MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Right180 = new System.Windows.Forms.ToolStripMenuItem();
            this.Vertical = new System.Windows.Forms.ToolStripMenuItem();
            this.Horizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.VerticalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUndo = new System.Windows.Forms.Button();
            this.backwardDiagonal = new System.Windows.Forms.Button();
            this.cross = new System.Windows.Forms.Button();
            this.diagonalBrick = new System.Windows.Forms.Button();
            this.gbBrushes = new System.Windows.Forms.GroupBox();
            this.largeConfetti = new System.Windows.Forms.Button();
            this.darkHorizontal = new System.Windows.Forms.Button();
            this.shingle = new System.Windows.Forms.Button();
            this.solidDiamond = new System.Windows.Forms.Button();
            this.sphere = new System.Windows.Forms.Button();
            this.wave = new System.Windows.Forms.Button();
            this.largeCheckerBoard = new System.Windows.Forms.Button();
            this.zigZag = new System.Windows.Forms.Button();
            this.smallConfetti = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbPencilSize = new System.Windows.Forms.Label();
            this.lbColor = new System.Windows.Forms.Label();
            this.canvasControl = new PaintApplication.View.CanvasControl();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).BeginInit();
            this.menu.SuspendLayout();
            this.gbBrushes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasControl)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPencil
            // 
            this.btnPencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPencil.BackgroundImage")));
            this.btnPencil.Location = new System.Drawing.Point(3, 12);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(68, 38);
            this.btnPencil.TabIndex = 1;
            this.btnPencil.Text = "Pencil";
            this.btnPencil.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnPencil.UseVisualStyleBackColor = true;
            this.btnPencil.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // btnRubber
            // 
            this.btnRubber.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRubber.BackgroundImage")));
            this.btnRubber.Location = new System.Drawing.Point(67, 12);
            this.btnRubber.Name = "btnRubber";
            this.btnRubber.Size = new System.Drawing.Size(68, 38);
            this.btnRubber.TabIndex = 4;
            this.btnRubber.Text = "Rubber";
            this.btnRubber.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnRubber.UseVisualStyleBackColor = true;
            this.btnRubber.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // btnBucket
            // 
            this.btnBucket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBucket.BackgroundImage")));
            this.btnBucket.Location = new System.Drawing.Point(132, 12);
            this.btnBucket.Name = "btnBucket";
            this.btnBucket.Size = new System.Drawing.Size(68, 38);
            this.btnBucket.TabIndex = 5;
            this.btnBucket.Text = "Bucket";
            this.btnBucket.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnBucket.UseVisualStyleBackColor = true;
            this.btnBucket.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCircle.BackgroundImage")));
            this.btnCircle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCircle.Location = new System.Drawing.Point(198, 12);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(68, 38);
            this.btnCircle.TabIndex = 6;
            this.btnCircle.Text = "Circle";
            this.btnCircle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRectangle.BackgroundImage")));
            this.btnRectangle.Location = new System.Drawing.Point(264, 12);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(68, 38);
            this.btnRectangle.TabIndex = 7;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLine.BackgroundImage")));
            this.btnLine.Location = new System.Drawing.Point(330, 12);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(68, 38);
            this.btnLine.TabIndex = 8;
            this.btnLine.Text = "Line";
            this.btnLine.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnTool_Click);
            // 
            // pbColor
            // 
            this.pbColor.BackColor = System.Drawing.Color.Black;
            this.pbColor.Location = new System.Drawing.Point(122, 63);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(41, 37);
            this.pbColor.TabIndex = 9;
            this.pbColor.TabStop = false;
            this.pbColor.Click += new System.EventHandler(this.pbColor_Click);
            // 
            // sizeTrackBar
            // 
            this.sizeTrackBar.Location = new System.Drawing.Point(12, 63);
            this.sizeTrackBar.Maximum = 25;
            this.sizeTrackBar.Minimum = 1;
            this.sizeTrackBar.Name = "sizeTrackBar";
            this.sizeTrackBar.Size = new System.Drawing.Size(104, 45);
            this.sizeTrackBar.TabIndex = 10;
            this.sizeTrackBar.Value = 1;
            this.sizeTrackBar.ValueChanged += new System.EventHandler(this.sizeTrackBar_ValueChanged);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.Right90,
            this.Vertical});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(784, 24);
            this.menu.TabIndex = 12;
            this.menu.Text = "menu";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMenuItem,
            this.saveMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            // 
            // loadMenuItem
            // 
            this.loadMenuItem.Name = "loadMenuItem";
            this.loadMenuItem.Size = new System.Drawing.Size(148, 22);
            this.loadMenuItem.Text = "Load from file";
            this.loadMenuItem.Click += new System.EventHandler(this.loadMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveMenuItem.Text = "Save";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // Right90
            // 
            this.Right90.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Left90,
            this.right90MenuItem,
            this.Right180});
            this.Right90.Name = "Right90";
            this.Right90.Size = new System.Drawing.Size(53, 20);
            this.Right90.Text = "Rotate";
            // 
            // Left90
            // 
            this.Left90.Name = "Left90";
            this.Left90.Size = new System.Drawing.Size(122, 22);
            this.Left90.Text = "Left 90°";
            this.Left90.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // right90MenuItem
            // 
            this.right90MenuItem.Name = "right90MenuItem";
            this.right90MenuItem.Size = new System.Drawing.Size(122, 22);
            this.right90MenuItem.Text = "Right 90°";
            this.right90MenuItem.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // Right180
            // 
            this.Right180.Name = "Right180";
            this.Right180.Size = new System.Drawing.Size(122, 22);
            this.Right180.Text = "180°";
            this.Right180.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // Vertical
            // 
            this.Vertical.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Horizontal,
            this.VerticalMenuItem});
            this.Vertical.Name = "Vertical";
            this.Vertical.Size = new System.Drawing.Size(38, 20);
            this.Vertical.Text = "Flip";
            // 
            // Horizontal
            // 
            this.Horizontal.Name = "Horizontal";
            this.Horizontal.Size = new System.Drawing.Size(129, 22);
            this.Horizontal.Text = "Horizontal";
            this.Horizontal.Click += new System.EventHandler(this.btnFlip_Click);
            // 
            // VerticalMenuItem
            // 
            this.VerticalMenuItem.Name = "VerticalMenuItem";
            this.VerticalMenuItem.Size = new System.Drawing.Size(129, 22);
            this.VerticalMenuItem.Text = "Vertical";
            this.VerticalMenuItem.Click += new System.EventHandler(this.btnFlip_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(697, 22);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 13;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // backwardDiagonal
            // 
            this.backwardDiagonal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backwardDiagonal.BackgroundImage")));
            this.backwardDiagonal.Location = new System.Drawing.Point(6, 19);
            this.backwardDiagonal.Name = "backwardDiagonal";
            this.backwardDiagonal.Size = new System.Drawing.Size(23, 23);
            this.backwardDiagonal.TabIndex = 14;
            this.backwardDiagonal.UseVisualStyleBackColor = true;
            this.backwardDiagonal.Click += new System.EventHandler(this.btnBrush_Click);
            // 
            // cross
            // 
            this.cross.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cross.BackgroundImage")));
            this.cross.Location = new System.Drawing.Point(27, 19);
            this.cross.Name = "cross";
            this.cross.Size = new System.Drawing.Size(23, 23);
            this.cross.TabIndex = 15;
            this.cross.UseVisualStyleBackColor = true;
            this.cross.Click += new System.EventHandler(this.btnBrush_Click);
            // 
            // diagonalBrick
            // 
            this.diagonalBrick.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("diagonalBrick.BackgroundImage")));
            this.diagonalBrick.Location = new System.Drawing.Point(49, 19);
            this.diagonalBrick.Name = "diagonalBrick";
            this.diagonalBrick.Size = new System.Drawing.Size(23, 23);
            this.diagonalBrick.TabIndex = 16;
            this.diagonalBrick.UseVisualStyleBackColor = true;
            this.diagonalBrick.Click += new System.EventHandler(this.btnBrush_Click);
            // 
            // gbBrushes
            // 
            this.gbBrushes.Controls.Add(this.largeConfetti);
            this.gbBrushes.Controls.Add(this.darkHorizontal);
            this.gbBrushes.Controls.Add(this.shingle);
            this.gbBrushes.Controls.Add(this.solidDiamond);
            this.gbBrushes.Controls.Add(this.sphere);
            this.gbBrushes.Controls.Add(this.wave);
            this.gbBrushes.Controls.Add(this.largeCheckerBoard);
            this.gbBrushes.Controls.Add(this.zigZag);
            this.gbBrushes.Controls.Add(this.smallConfetti);
            this.gbBrushes.Controls.Add(this.backwardDiagonal);
            this.gbBrushes.Controls.Add(this.diagonalBrick);
            this.gbBrushes.Controls.Add(this.cross);
            this.gbBrushes.Location = new System.Drawing.Point(405, 3);
            this.gbBrushes.Name = "gbBrushes";
            this.gbBrushes.Size = new System.Drawing.Size(274, 47);
            this.gbBrushes.TabIndex = 17;
            this.gbBrushes.TabStop = false;
            this.gbBrushes.Text = "Brushes";
            // 
            // largeConfetti
            // 
            this.largeConfetti.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("largeConfetti.BackgroundImage")));
            this.largeConfetti.Location = new System.Drawing.Point(246, 19);
            this.largeConfetti.Name = "largeConfetti";
            this.largeConfetti.Size = new System.Drawing.Size(23, 23);
            this.largeConfetti.TabIndex = 25;
            this.largeConfetti.UseVisualStyleBackColor = true;
            this.largeConfetti.Click += new System.EventHandler(this.btnBrush_Click);
            // 
            // darkHorizontal
            // 
            this.darkHorizontal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("darkHorizontal.BackgroundImage")));
            this.darkHorizontal.Location = new System.Drawing.Point(224, 19);
            this.darkHorizontal.Name = "darkHorizontal";
            this.darkHorizontal.Size = new System.Drawing.Size(23, 23);
            this.darkHorizontal.TabIndex = 24;
            this.darkHorizontal.UseVisualStyleBackColor = true;
            this.darkHorizontal.Click += new System.EventHandler(this.btnBrush_Click);
            // 
            // shingle
            // 
            this.shingle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shingle.BackgroundImage")));
            this.shingle.Location = new System.Drawing.Point(202, 19);
            this.shingle.Name = "shingle";
            this.shingle.Size = new System.Drawing.Size(23, 23);
            this.shingle.TabIndex = 23;
            this.shingle.UseVisualStyleBackColor = true;
            this.shingle.Click += new System.EventHandler(this.btnBrush_Click);
            // 
            // solidDiamond
            // 
            this.solidDiamond.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("solidDiamond.BackgroundImage")));
            this.solidDiamond.Location = new System.Drawing.Point(180, 19);
            this.solidDiamond.Name = "solidDiamond";
            this.solidDiamond.Size = new System.Drawing.Size(23, 23);
            this.solidDiamond.TabIndex = 22;
            this.solidDiamond.UseVisualStyleBackColor = true;
            this.solidDiamond.Click += new System.EventHandler(this.btnBrush_Click);
            // 
            // sphere
            // 
            this.sphere.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sphere.BackgroundImage")));
            this.sphere.Location = new System.Drawing.Point(158, 19);
            this.sphere.Name = "sphere";
            this.sphere.Size = new System.Drawing.Size(23, 23);
            this.sphere.TabIndex = 21;
            this.sphere.UseVisualStyleBackColor = true;
            this.sphere.Click += new System.EventHandler(this.btnBrush_Click);
            // 
            // wave
            // 
            this.wave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wave.BackgroundImage")));
            this.wave.Location = new System.Drawing.Point(136, 19);
            this.wave.Name = "wave";
            this.wave.Size = new System.Drawing.Size(23, 23);
            this.wave.TabIndex = 20;
            this.wave.UseVisualStyleBackColor = true;
            this.wave.Click += new System.EventHandler(this.btnBrush_Click);
            // 
            // largeCheckerBoard
            // 
            this.largeCheckerBoard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("largeCheckerBoard.BackgroundImage")));
            this.largeCheckerBoard.Location = new System.Drawing.Point(114, 19);
            this.largeCheckerBoard.Name = "largeCheckerBoard";
            this.largeCheckerBoard.Size = new System.Drawing.Size(23, 23);
            this.largeCheckerBoard.TabIndex = 19;
            this.largeCheckerBoard.UseVisualStyleBackColor = true;
            this.largeCheckerBoard.Click += new System.EventHandler(this.btnBrush_Click);
            // 
            // zigZag
            // 
            this.zigZag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zigZag.BackgroundImage")));
            this.zigZag.Location = new System.Drawing.Point(92, 19);
            this.zigZag.Name = "zigZag";
            this.zigZag.Size = new System.Drawing.Size(23, 23);
            this.zigZag.TabIndex = 18;
            this.zigZag.UseVisualStyleBackColor = true;
            this.zigZag.Click += new System.EventHandler(this.btnBrush_Click);
            // 
            // smallConfetti
            // 
            this.smallConfetti.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("smallConfetti.BackgroundImage")));
            this.smallConfetti.Location = new System.Drawing.Point(70, 19);
            this.smallConfetti.Name = "smallConfetti";
            this.smallConfetti.Size = new System.Drawing.Size(23, 23);
            this.smallConfetti.TabIndex = 17;
            this.smallConfetti.UseVisualStyleBackColor = true;
            this.smallConfetti.Click += new System.EventHandler(this.btnBrush_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.canvasControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 537);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(180)))));
            this.panel2.Controls.Add(this.lbPencilSize);
            this.panel2.Controls.Add(this.gbBrushes);
            this.panel2.Controls.Add(this.lbColor);
            this.panel2.Controls.Add(this.btnPencil);
            this.panel2.Controls.Add(this.btnRubber);
            this.panel2.Controls.Add(this.btnBucket);
            this.panel2.Controls.Add(this.btnUndo);
            this.panel2.Controls.Add(this.btnCircle);
            this.panel2.Controls.Add(this.btnRectangle);
            this.panel2.Controls.Add(this.sizeTrackBar);
            this.panel2.Controls.Add(this.btnLine);
            this.panel2.Controls.Add(this.pbColor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 114);
            this.panel2.TabIndex = 19;
            // 
            // lbPencilSize
            // 
            this.lbPencilSize.AutoSize = true;
            this.lbPencilSize.Location = new System.Drawing.Point(35, 95);
            this.lbPencilSize.Name = "lbPencilSize";
            this.lbPencilSize.Size = new System.Drawing.Size(59, 13);
            this.lbPencilSize.TabIndex = 19;
            this.lbPencilSize.Text = "Pencil Size";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(119, 92);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(31, 13);
            this.lbColor.TabIndex = 18;
            this.lbColor.Text = "Color";
            // 
            // canvasControl
            // 
            this.canvasControl.BackColor = System.Drawing.Color.White;
            this.canvasControl.Location = new System.Drawing.Point(3, 120);
            this.canvasControl.Name = "canvasControl";
            this.canvasControl.Size = new System.Drawing.Size(400, 400);
            this.canvasControl.TabIndex = 3;
            this.canvasControl.TabStop = false;
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.Name = "PaintForm";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.gbBrushes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPencil;
        private CanvasControl canvasControl;
        private Button btnRubber;
        private Button btnBucket;
        private Button btnCircle;
        private Button btnRectangle;
        private Button btnLine;
        private PictureBox pbColor;
        private ColorDialog colorDialog;
        private TrackBar sizeTrackBar;
        private MenuStrip menu;
        private ToolStripMenuItem fileMenuItem;
        private ToolStripMenuItem loadMenuItem;
        private ToolStripMenuItem saveMenuItem;
        private ToolStripMenuItem Right90;
        private ToolStripMenuItem Vertical;
        private ToolStripMenuItem Left90;
        private ToolStripMenuItem right90MenuItem;
        private ToolStripMenuItem Right180;
        private ToolStripMenuItem Horizontal;
        private ToolStripMenuItem VerticalMenuItem;
        private Button btnUndo;
        private Button backwardDiagonal;
        private Button cross;
        private Button diagonalBrick;
        private GroupBox gbBrushes;
        private Button smallConfetti;
        private Button zigZag;
        private Button largeCheckerBoard;
        private Button wave;
        private Button sphere;
        private Button solidDiamond;
        private Button shingle;
        private Button darkHorizontal;
        private Button largeConfetti;
        private Panel panel1;
        private Panel panel2;
        private Label lbColor;
        private Label lbPencilSize;
    }
}

