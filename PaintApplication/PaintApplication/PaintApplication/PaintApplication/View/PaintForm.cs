using System;
using System.Drawing;
using System.Windows.Forms;
using PaintApplication.Model;
using PaintApplication.Model.FlipItems;
using PaintApplication.Model.RotateItems;
using PaintApplication.Model.Utility;

namespace PaintApplication.View
{
    public partial class PaintForm : Form
    {
        public event Action<Point> StartPaintAction;
        public event Action<Point> StopPaintAction;
        public event Action <PaintToolType>ToolAction;
        public event Action<Point> MovePaintAction;
        public event Action<Color> ColorAction;
        public event Action<int> SizePenAction;
        public event Action<int, int> SizeChangeAction;
        public event Action SaveAction;
        public event Action<string> LoadAction;
        public event Action<RotateTypes> RotateAction;
        public event Action<FlipType> FlipAction;
        public event Action UndoAction;
        public event Action<BrushType> BrushAction;

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
            canvasControl.UpdateCanvasSize(image);
        }

        private void btnTool_Click(object sender, EventArgs e)
        {
            PaintToolType paintToolType = PaintToolType.None;
            Button button = sender as Button;
            paintToolType = EnumUtil.ParseEnum<PaintToolType>(button?.Text);
            sizeTrackBar.Enabled = true;
            ToolAction?.Invoke(paintToolType);
        }
        private void btnBrush_Click(object sender, EventArgs e)
        {
            BrushType brushType = BrushType.CrossBrush;
            Button button = sender as Button;
            brushType = EnumUtil.ParseEnum<BrushType>(button?.Name);
            sizeTrackBar.Enabled = false;
            BrushAction?.Invoke(brushType);
        }

        private void pbColor_Click(object sender, EventArgs e)
        { 
            if (colorDialog.ShowDialog()== DialogResult.OK)
            {
                pbColor.BackColor = colorDialog.Color;
                ColorAction?.Invoke(colorDialog.Color);
            }
        }

        private void sizeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            SizePenAction?.Invoke(sizeTrackBar.Value);
        }

        private void canvasControl_SizeChanged()
        {
            SizeChangeAction?.Invoke(canvasControl.Width, canvasControl.Height);
        }
        
        private void loadMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadAction?.Invoke(openFileDialog.FileName);
            }
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            SaveAction?.Invoke();
        }
        private void btnRotate_Click(object sender, EventArgs e)
        {
            RotateTypes rotateTypes = RotateTypes.None;
            ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
            rotateTypes = EnumUtil.ParseEnum<RotateTypes>(toolStripMenuItem?.Name);
            RotateAction?.Invoke(rotateTypes);
        }
        private void btnFlip_Click(object sender, EventArgs e)
        {
            FlipType flipType = FlipType.None;
            ToolStripMenuItem toolStripMenuItem = sender as ToolStripMenuItem;
            flipType = EnumUtil.ParseEnum<FlipType>(toolStripMenuItem?.Name);
            FlipAction?.Invoke(flipType);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            UndoAction?.Invoke();
        }
    }
}
