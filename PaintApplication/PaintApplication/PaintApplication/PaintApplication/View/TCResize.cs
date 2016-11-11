using System;
using System.Windows.Forms;

namespace PaintApplication.View
{
    public class TCResize
    {
        public Action SizeIsChanged;
        readonly Control controltobeResized;
        static readonly int decoration = 3;
        public static int Decoration
        {
            get { return decoration; }
        }


        public TCResize(PictureBox theControl)
        {
            controltobeResized = theControl;
            InitializeComponent();
            controltobeResized.Controls.Add(pictureBox1);
            controltobeResized.Controls.Add(pictureBox2);
            controltobeResized.Controls.Add(pictureBox3);
            theControl.Parent.Controls.Add(label1);
        }

        private PictureBox pictureBox1 = new PictureBox();
        private PictureBox pictureBox2 = new PictureBox();
        private PictureBox pictureBox3 = new PictureBox();
        private Label label1 = new Label();
        private bool _sizeChanged = false;


        private void InitializeComponent()
        {
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom
                        | System.Windows.Forms.AnchorStyles.Right);
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.pictureBox1.Location = new System.Drawing.Point(controltobeResized.GetClientWidth(), 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(decoration, controltobeResized.GetClientHeight());
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pictureBox1.MouseUp += new MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left
                        | System.Windows.Forms.AnchorStyles.Right);
            this.pictureBox2.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.pictureBox2.Location = new System.Drawing.Point(0, controltobeResized.GetClientHeight());
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(controltobeResized.GetClientWidth(), decoration);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pictureBox2.MouseUp += new MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
            this.pictureBox3.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pictureBox3.Location = new System.Drawing.Point(controltobeResized.GetClientWidth(), controltobeResized.GetClientHeight());
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(decoration, decoration);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(pictureBox3_MouseDown);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pictureBox3.MouseUp += new MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Visible = false;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(297, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
        }

        void ShowTCTip()
        {
            label1.Visible = true;
            label1.Text = "Size:(" + controltobeResized.GetClientWidth() + "," + controltobeResized.GetClientHeight() + ")";
            label1.Top = controltobeResized.Bottom + decoration;
            if (label1.Width > controltobeResized.Width)
            {
                label1.Left = controltobeResized.Left;
            }
            else
            {
                label1.Left = controltobeResized.Right - label1.Width;
            }
            label1.BringToFront();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                controltobeResized.Width += e.X;
                if (controltobeResized.Width < decoration)
                {
                    controltobeResized.Width = decoration;
                }
                _sizeChanged = true;
            }
            
            ShowTCTip();
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                controltobeResized.Height += e.Y;
                if (controltobeResized.Height < decoration)
                {
                    controltobeResized.Height = decoration;
                }
                _sizeChanged = true;
            }
            
            ShowTCTip();
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                controltobeResized.Width += e.X;
                controltobeResized.Height += e.Y;
                if (controltobeResized.Width < decoration)
                {
                    controltobeResized.Width = decoration;
                }
                if (controltobeResized.Height < decoration)
                {
                    controltobeResized.Height = decoration;
                }
                _sizeChanged = true;
            }
            
            ShowTCTip();
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            SizeIsChanged?.Invoke();
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            ShowTCTip();
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
    }
}
