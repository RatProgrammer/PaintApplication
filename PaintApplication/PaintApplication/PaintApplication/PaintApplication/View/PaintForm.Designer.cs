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
            this.label1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inversMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canvasControl = new PaintApplication.View.CanvasControl();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasControl)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPencil
            // 
            this.btnPencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPencil.BackgroundImage")));
            this.btnPencil.Location = new System.Drawing.Point(0, 27);
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
            this.btnRubber.Location = new System.Drawing.Point(74, 27);
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
            this.btnBucket.Location = new System.Drawing.Point(148, 27);
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
            this.btnCircle.Location = new System.Drawing.Point(222, 27);
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
            this.btnRectangle.Location = new System.Drawing.Point(287, 27);
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
            this.btnLine.Location = new System.Drawing.Point(361, 27);
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
            this.pbColor.Location = new System.Drawing.Point(435, 28);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(41, 37);
            this.pbColor.TabIndex = 9;
            this.pbColor.TabStop = false;
            this.pbColor.Click += new System.EventHandler(this.pbColor_Click);
            // 
            // sizeTrackBar
            // 
            this.sizeTrackBar.Location = new System.Drawing.Point(491, 28);
            this.sizeTrackBar.Maximum = 25;
            this.sizeTrackBar.Minimum = 1;
            this.sizeTrackBar.Name = "sizeTrackBar";
            this.sizeTrackBar.Size = new System.Drawing.Size(104, 45);
            this.sizeTrackBar.TabIndex = 10;
            this.sizeTrackBar.Value = 1;
            this.sizeTrackBar.ValueChanged += new System.EventHandler(this.sizeTrackBar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.rotateMenuItem,
            this.inversMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(915, 24);
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
            this.loadMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadMenuItem.Text = "Load from file";
            this.loadMenuItem.Click += new System.EventHandler(this.loadMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveMenuItem.Text = "Save";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // rotateMenuItem
            // 
            this.rotateMenuItem.Name = "rotateMenuItem";
            this.rotateMenuItem.Size = new System.Drawing.Size(53, 20);
            this.rotateMenuItem.Text = "Rotate";
            // 
            // inversMenuItem
            // 
            this.inversMenuItem.Name = "inversMenuItem";
            this.inversMenuItem.Size = new System.Drawing.Size(50, 20);
            this.inversMenuItem.Text = "Invers";
            // 
            // canvasControl
            // 
            this.canvasControl.BackColor = System.Drawing.Color.White;
            this.canvasControl.Location = new System.Drawing.Point(24, 84);
            this.canvasControl.Name = "canvasControl";
            this.canvasControl.Size = new System.Drawing.Size(400, 400);
            this.canvasControl.TabIndex = 3;
            this.canvasControl.TabStop = false;
            this.canvasControl.SizeChanged += new System.EventHandler(this.canvasControl_SizeChanged);
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(915, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizeTrackBar);
            this.Controls.Add(this.pbColor);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnBucket);
            this.Controls.Add(this.btnRubber);
            this.Controls.Add(this.canvasControl);
            this.Controls.Add(this.btnPencil);
            this.Controls.Add(this.menu);
            this.Name = "PaintForm";
            this.Text = "PaintForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
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
        private Label label1;
        private MenuStrip menu;
        private ToolStripMenuItem fileMenuItem;
        private ToolStripMenuItem loadMenuItem;
        private ToolStripMenuItem saveMenuItem;
        private ToolStripMenuItem rotateMenuItem;
        private ToolStripMenuItem inversMenuItem;
    }
}

