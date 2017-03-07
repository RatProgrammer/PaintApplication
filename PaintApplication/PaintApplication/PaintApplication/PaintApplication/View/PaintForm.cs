using System;
using System.Drawing;
using System.Windows.Forms;

namespace PaintApplication.View
{
    public partial class PaintForm : Form, IPaintForm
    {
        public event Action StartPaintAction;
        public event Action StopPaintAction;
        public event Action ToolAction;
        public event Action MovePaintAction;
        public event Action ColorAction;
        public event Action SizePenAction;
        public event Action SizeChangeAction;
        public event Action SaveAction;
        public event Action LoadAction;
        public event Action RotateAction;
        public event Action FlipAction;
        public event Action UndoAction;
        public event Action BrushAction;
        public Point MouseLocation { get; set; }
        public string ToolType { get; set; }
        public Color ColorBrush { get; set; }
        public int PenSize { get; set; }
        public int CanvasSizeWidth { get; set; }
        public int CanvasSizeHeight { get; set; }
        public string FileLocationName { get; set; }
        public string RotateType { get; set; }
        public string FlipType { get; set; }
        public string BrushType { get; set; }

        public PaintForm()
        {
            InitializeComponent();
            Resizer resizer = new Resizer(canvasControl);
            resizer.SizeIsChanged += canvasControl_SizeChanged;
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
            MouseLocation = e.Location;
            MovePaintAction?.Invoke();
        }

        private void canvas_StartPaint(MouseEventArgs e)
        {
            MouseLocation = e.Location;
            StartPaintAction?.Invoke();
        }

        private void canvas_StopPaint(MouseEventArgs e)
        {
            MouseLocation = e.Location;
            StopPaintAction?.Invoke();
        }

        public void UpdateCanvas(Image image)
        {
            canvasControl.UpdateCanvasSize(image);
        }

        private void btnTool_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            ToolType = button?.Text;
            sizeTrackBar.Enabled = true;
            ToolAction?.Invoke();
        }
        private void btnBrush_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            BrushType = button?.Name;
            ToolType = "Brush";
            sizeTrackBar.Enabled = false;
            BrushAction?.Invoke();
            ToolAction?.Invoke();
        }

        private void pbColor_Click(object sender, EventArgs e)
        { 
            if (colorDialog.ShowDialog()== DialogResult.OK)
            {
                ColorBrush = colorDialog.Color;
                pbColor.BackColor = ColorBrush;
                ColorAction?.Invoke();
            }
        }

        private void sizeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            PenSize = sizeTrackBar.Value;
            SizePenAction?.Invoke();
        }

        private void canvasControl_SizeChanged()
        {
            CanvasSizeWidth = canvasControl.Width;
            CanvasSizeHeight = canvasControl.Height;
            SizeChangeAction?.Invoke();
        }
        
        private void loadMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileLocationName = openFileDialog.FileName;
                LoadAction?.Invoke();
            }
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            SaveAction?.Invoke();
        }
        private void btnRotate_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
            RotateType = toolStripMenuItem?.Name;
            RotateAction?.Invoke();
        }
        private void btnFlip_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
            FlipType = toolStripMenuItem?.Name;
            FlipAction?.Invoke();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            UndoAction?.Invoke();
        }
    }
}
