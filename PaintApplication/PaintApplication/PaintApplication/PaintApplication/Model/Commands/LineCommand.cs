using System;
using System.Drawing;

namespace PaintApplication.Model.Commands
{
    class LineCommand:IPaintCommand
    {
        private Point _startPoint;

        public event Action SnapshotEvent;

        public void ExecuteStart(ref Canvas temporary, ref Canvas currentCanvas, PaintTool paintTool, Point point)
        {
            _startPoint = point;
        }

        public void ExecuteStop(ref Canvas temporary, ref Canvas current, PaintTool paintTool, Point point)
        {
            if (!(_startPoint.X == point.X && _startPoint.Y == point.Y))
                SnapshotEvent?.Invoke();
            using (Graphics graphics = Graphics.FromImage(current.Bitmap))
            {
                graphics.DrawLine(paintTool.Pen, _startPoint, point);
            }
        }

        public void ExecuteMove(ref Canvas temporary, ref Canvas current, PaintTool paintTool, Point point)
        {
            using (Graphics graphics = Graphics.FromImage(temporary.Bitmap))
            {
                graphics.DrawLine(paintTool.Pen, _startPoint, point);
            }
        }
    }
}
