using System;
using System.Drawing;
using System.Windows.Forms;
using PaintApplication.Model;

namespace PaintApplication.View
{
    public partial class PaintForm : Form
    {
        public event Action<Point> StartPaintAction;
        public event Action<Point> StopPaintAction;
        public event Action PencilDrawAction;

        public PaintForm()
        {
            InitializeComponent();
            InitCanvas();
        }

        private void InitCanvas()
        {
            canvasControl.StartPaint += canvas_StartPaint;
            canvasControl.StopPaint += canvas_StopPaint;
        }

        private void canvas_StartPaint(MouseEventArgs e)
        {
            StartPaintAction?.Invoke(e.Location);
        }

        private void canvas_StopPaint(MouseEventArgs e)
        {
            StopPaintAction?.Invoke(e.Location);
        }

        public void UpdateCanvas(Image image)
        {
            canvasControl.Image = image;
            canvasControl.Refresh();
        }

        private void btnPencil_Click(object sender, EventArgs e)
        {
            PencilDrawAction?.Invoke();
        }
    }
}
