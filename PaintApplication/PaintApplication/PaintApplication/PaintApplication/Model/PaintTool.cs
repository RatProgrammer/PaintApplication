using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PaintApplication.Model
{
    internal class PaintTool
    {
        public Point StartPoint { get; private set; }
        public Point EndPoint { get; private set; }
        public Color Color { get; private set; }
        public Pen Pen { get; private set; }
        public Brush Brush { get; private set; }
        private float _penSize = 1;
        private HatchStyle _hatchStyle;
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
            Brush = _brushFactory.CreateBrush(_hatchStyle, color);
        }

        public void SetPenSize(int penSize)
        {
            _penSize = penSize;
            Pen.Width = penSize;
        }

        public void SetBrush(HatchStyle hatchStyle)
        {
            Brush = _brushFactory.CreateBrush(hatchStyle, Color);
            _hatchStyle = hatchStyle;
        }

        public void SetPen(Pen pen)
        {
            Pen = pen;
        }

        public void SetStartPoint(Point point)
        {
            StartPoint = point;
        }

        public void SetEndPoint(Point point)
        {
            EndPoint = point;
        }
    }
}