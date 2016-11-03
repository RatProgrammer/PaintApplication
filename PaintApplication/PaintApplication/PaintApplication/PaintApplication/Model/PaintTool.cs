using System.Drawing;

namespace PaintApplication.Model
{
    internal class PaintTool
    {
        public Color Color { get; private set; }
        public Pen Pen { get; private set; }

        private float _penSize;

        public Brush Brush { get; private set; }

        public PaintTool()
        {
            _penSize = 1;
            Color = Color.Black;
            Pen=new Pen(Color,_penSize);
        }
        public void SetColor(Color color)
        {
            Color = color;
            Pen.Color = color;
        }

        public void SetPenSize(int penSize)
        {
            _penSize = penSize;
            Pen.Width = penSize;
        }

        public void SetBrush(Brush brush)
        {
            Brush = brush;
        }

        public void SetPen(Pen pen)
        {
            Pen = pen;
        }
    }
}