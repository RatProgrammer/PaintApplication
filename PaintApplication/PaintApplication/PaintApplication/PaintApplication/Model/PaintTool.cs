using System.Drawing;
using System.Drawing.Drawing2D;
using PaintApplication.Model.Commands;

namespace PaintApplication.Model
{
    internal class PaintTool
    {
        public Color Color { get; private set; }
        public Pen Pen { get; private set; }

        private float _penSize;

        public Brush Brush { get; private set; }

        private BrushType _brushType;
        private BrushFactory _brushFactory;

        public PaintTool()
        {
            _penSize = 1;
            Color = Color.Black;
            Pen=new Pen(Color,_penSize);
            _brushFactory = new BrushFactory(); 
        }
        public void SetColor(Color color)
        {
            Color = color;
            Pen.Color = color;
            Brush = _brushFactory.CreateBrush(_brushType, color);
        }

        public void SetPenSize(int penSize)
        {
            _penSize = penSize;
            Pen.Width = penSize;
        }

        public void SetBrush(BrushType brushType)
        {
            Brush= _brushFactory.CreateBrush(brushType, Color);
            _brushType = brushType;
        }

        public void SetPen(Pen pen)
        {
            Pen = pen;
        }
    }
}