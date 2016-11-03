using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using PaintApplication.Model;
using PaintApplication.Model.Utility;

namespace PaintApplication.View
{
    public partial class PaintForm : Form
    {
        public event Action<Point> StartPaintAction;
        public event Action<Point> StopPaintAction;
        public event Action <PaintToolType>ToolAction;
        public event Action<Point> MovePaintAction;

        public PaintForm()
        {
            InitializeComponent();
            InitCanvas();
        }




        private void InitCanvas()
        {
            canvasControl.StartPaint += canvas_StartPaint;
            canvasControl.StopPaint += canvas_StopPaint;
            canvasControl.MovePaint += canvas_MovePaint;
        }

        private void canvas_MovePaint(MouseEventArgs e)
        {
            MovePaintAction?.Invoke(e.Location);
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
            canvasControl.Invalidate();
            canvasControl.Refresh();
        }

        private void btnTool_Click(object sender, EventArgs e)
        {
            PaintToolType paintToolType = PaintToolType.None;
            Button button = sender as Button;
            paintToolType = EnumUtil.ParseEnum<PaintToolType>(button?.Text);
            ToolAction?.Invoke(paintToolType);
        }
    }
}
