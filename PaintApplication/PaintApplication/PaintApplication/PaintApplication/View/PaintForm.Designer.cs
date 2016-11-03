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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.canvasControl = new PaintApplication.View.CanvasControl();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvasControl)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPencil
            // 
            this.btnPencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPencil.BackgroundImage")));
            this.btnPencil.Location = new System.Drawing.Point(24, 11);
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
            this.btnRubber.Location = new System.Drawing.Point(98, 12);
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
            this.btnBucket.Location = new System.Drawing.Point(172, 11);
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
            this.btnCircle.Location = new System.Drawing.Point(246, 12);
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
            this.btnRectangle.Location = new System.Drawing.Point(320, 12);
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
            this.btnLine.Location = new System.Drawing.Point(394, 12);
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
            this.pbColor.Location = new System.Drawing.Point(469, 13);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(41, 37);
            this.pbColor.TabIndex = 9;
            this.pbColor.TabStop = false;
            this.pbColor.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // canvasControl
            // 
            this.canvasControl.BackColor = System.Drawing.Color.White;
            this.canvasControl.Location = new System.Drawing.Point(24, 84);
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
            this.ClientSize = new System.Drawing.Size(738, 561);
            this.Controls.Add(this.pbColor);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnBucket);
            this.Controls.Add(this.btnRubber);
            this.Controls.Add(this.canvasControl);
            this.Controls.Add(this.btnPencil);
            this.Name = "PaintForm";
            this.Text = "PaintForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvasControl)).EndInit();
            this.ResumeLayout(false);

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
        private ColorDialog colorDialog1;
    }
}

