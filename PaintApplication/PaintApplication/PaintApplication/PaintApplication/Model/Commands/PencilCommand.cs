using System;
using System.Drawing;

namespace PaintApplication.Model.Commands
{
    class PencilCommand : IPaintCommand
    {
        private Point _previousPoint;
        private Graphics _graphics;

        public event Action SnapshotEvent;

        public void ExecuteStart(ref Bitmap temporary, ref Bitmap current, PaintTool paintTool, Point point)
        {
            SnapshotEvent?.Invoke();
            Point startPoint = point;
            current.SetPixel(startPoint.X, startPoint.Y, paintTool.Color);
             _previousPoint = point;
        }

        public void ExecuteStop(ref Bitmap temporary, ref Bitmap current, PaintTool paintTool, Point point)
        {
            _previousPoint = new Point(0, 0);
        }

        public void ExecuteMove(ref Bitmap temporary, ref Bitmap current, PaintTool paintTool, Point point)
        {
            Point startPoint = point;
            using (_graphics = Graphics.FromImage(current))
            {
                _graphics.DrawLine(paintTool.Pen, startPoint, _previousPoint);
            }
            _previousPoint = point;
        }
    }
}
