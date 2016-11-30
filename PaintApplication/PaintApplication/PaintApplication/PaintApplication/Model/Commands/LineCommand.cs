using System;
using System.Drawing;

namespace PaintApplication.Model.Commands
{
    class LineCommand:IPaintCommand
    {
        private Point _startPoint;

        public event Action SnapshotEvent;

        public void ExecuteStart(ref Bitmap temporary, ref Bitmap currentBitmap, PaintTool paintTool, Point point)
        {
            _startPoint = point;
        }

        public void ExecuteStop(ref Bitmap temporary, ref Bitmap current, PaintTool paintTool, Point point)
        {
            if (!(_startPoint.X == point.X && _startPoint.Y == point.Y))
                SnapshotEvent?.Invoke();
            using (Graphics graphics = Graphics.FromImage(current))
            {
                graphics.DrawLine(paintTool.Pen, _startPoint, point);
            }
        }

        public void ExecuteMove(ref Bitmap temporary, ref Bitmap current, PaintTool paintTool, Point point)
        {
            using (Graphics graphics = Graphics.FromImage(temporary))
            {
                graphics.DrawLine(paintTool.Pen, _startPoint, point);
            }
        }
    }
}
