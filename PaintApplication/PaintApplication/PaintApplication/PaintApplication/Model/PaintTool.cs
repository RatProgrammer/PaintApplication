using System;
using System.Drawing;

namespace PaintApplication.Model
{
    internal class PaintTool
    {
        public Color Color { get; private set; }
        public Pen Pen { get; private set; }
        public Brush Brush { get; private set; }
        private float _penSize = 1;
        private BrushType _brushType;
        private readonly BrushFactory _brushFactory;

        public PaintTool(Func<Color, float, Pen> pen, BrushFactory brushFactory)
        {
            Color = Color.Black;
            Pen = pen(Color,_penSize);
            _brushFactory = brushFactory; 
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
            Brush = _brushFactory.CreateBrush(brushType, Color);
            _brushType = brushType;
        }

        public void SetPen(Pen pen)
        {
            Pen = pen;
        }
    }
}