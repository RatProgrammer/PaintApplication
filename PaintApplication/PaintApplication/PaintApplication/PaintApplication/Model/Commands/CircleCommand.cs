using System;
using System.Drawing;

namespace PaintApplication.Model.Commands
{
    class CircleCommand : IPaintCommand
    {
        private Point _startPoint;
        private Rectangle _rectangle;

        public void ExecuteStart(ref Bitmap temporary, ref Bitmap current, ref PaintTool paintTool, Point point)
        {
            _startPoint = point;
            _rectangle = new Rectangle();
        }

        public void ExecuteStop(ref Bitmap temporary, ref Bitmap current, ref PaintTool paintTool, Point point)
        {
            using (Graphics graphics = Graphics.FromImage(current))
            {
                _rectangle.Location = new Point(Math.Min(_startPoint.X, point.X), Math.Min(_startPoint.Y, point.Y));
                _rectangle.Size = new Size(Math.Abs(_startPoint.X - point.X), Math.Abs(_startPoint.Y - point.Y));
                graphics.DrawEllipse(paintTool.Pen, _rectangle);
            }
        }

        public void ExecuteMove(ref Bitmap temporary, ref Bitmap current, ref PaintTool paintTool, Point point)
        {
            using (Graphics graphics = Graphics.FromImage(temporary))
            {
                _rectangle.Location = new Point(Math.Min(_startPoint.X, point.X), Math.Min(_startPoint.Y, point.Y));
                _rectangle.Size = new Size(Math.Abs(_startPoint.X - point.X), Math.Abs(_startPoint.Y - point.Y));
                graphics.DrawEllipse(paintTool.Pen, _rectangle);
            }
        }
    }
}
