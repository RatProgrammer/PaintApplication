using System;
using System.Drawing;

namespace PaintApplication.Model.Commands
{
    class CircleCommand : IPaintCommand
    {
        private Point _startPoint;
        private Rectangle _rectangle;

        public event Action SnapshotEvent;

        public void ExecuteStart(ref Bitmap temporary, ref Bitmap currentBitmap, PaintTool paintTool, Point point)
        {
            _startPoint = point;
            _rectangle = new Rectangle();
        }

        public void ExecuteStop(ref Bitmap temporary, ref Bitmap current, PaintTool paintTool, Point point)
        {
            if(!(_startPoint.X == point.X && _startPoint.Y == point.Y))
                SnapshotEvent?.Invoke();
            using (Graphics graphics = Graphics.FromImage(current))
            {
                _rectangle.Location = RectangleUtil.GetLocation(_startPoint, point);
                _rectangle.Size = RectangleUtil.GetSize(_startPoint, point);
                graphics.DrawEllipse(paintTool.Pen, _rectangle);
            }
        }

        public void ExecuteMove(ref Bitmap temporary, ref Bitmap current, PaintTool paintTool, Point point)
        {
            using (Graphics graphics = Graphics.FromImage(temporary))
            {
                _rectangle.Location = RectangleUtil.GetLocation(_startPoint, point);
                _rectangle.Size = RectangleUtil.GetSize(_startPoint, point);
                graphics.DrawEllipse(paintTool.Pen, _rectangle);
            }
        }
    }
}
