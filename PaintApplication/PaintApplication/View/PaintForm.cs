using System;
using System.Drawing;
using System.Windows.Forms;
using PaintApplication.Model;

namespace PaintApplication.View
{
    public partial class PaintForm : Form
    {
        public event Action<MouseEventArgs> StartPaintAction;
        public event Action<MouseEventArgs> StopPaintAction;

        public PaintForm()
        {
            InitializeComponent();
        }

        private void canvas_StartPaint(MouseEventArgs e)
        {
            StartPaintAction?.Invoke(e);
        }

        private void canvas_StopPaint(MouseEventArgs e)
        {
            StopPaintAction?.Invoke(e);
        }

        public void UpdateCanvas(Image image)
        {
            canvas1.Image = image;
            canvas1.Refresh();
        }
    }
}
