using System;
using System.Drawing;

namespace PaintApplication.Model.Commands
{
    class RectagleCommand : IPaintCommand
    {
        private Point _startPoint;
        private Rectangle _rectangle;

        public event Action SnapshotEvent;

        public void ExecuteStart(ref Canvas temporary, ref Canvas currentCanvas, PaintTool paintTool, Point point)
        {
            _startPoint = point;
            _rectangle = new Rectangle();
        }

        public void ExecuteStop(ref Canvas temporary, ref Canvas current, PaintTool paintTool, Point point)
        {
            if (!(_startPoint.X == point.X && _startPoint.Y == point.Y))
                SnapshotEvent?.Invoke();
            using (Graphics graphics = Graphics.FromImage(current.Bitmap))
            {
                _rectangle.Location = RectangleUtil.GetLocation(_startPoint, point);
                _rectangle.Size = RectangleUtil.GetSize(_startPoint, point);
                graphics.DrawRectangle(paintTool.Pen, _rectangle);
            }
        }

        public void ExecuteMove(ref Canvas temporary, ref Canvas current, PaintTool paintTool, Point point)
        {
            using (Graphics graphics = Graphics.FromImage(temporary.Bitmap))
            {
                _rectangle.Location = RectangleUtil.GetLocation(_startPoint, point);
                _rectangle.Size = RectangleUtil.GetSize(_startPoint, point);
                graphics.DrawRectangle(paintTool.Pen, _rectangle);
            }
        }
    }
}
