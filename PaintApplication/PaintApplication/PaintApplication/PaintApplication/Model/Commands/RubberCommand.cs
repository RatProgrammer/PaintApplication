using System;
using System.Drawing;

namespace PaintApplication.Model.Commands
{
    class RubberCommand : IPaintCommand
    {
        private Point _startPoint;
        private Graphics _graphics;
        public event Action SnapshotEvent;

        public void ExecuteStart(ref Bitmap temporary, ref Bitmap currentBitmap, PaintTool paintTool, Point point)
        {
            SnapshotEvent?.Invoke();
            using (_graphics = Graphics.FromImage(currentBitmap))
            {
                _startPoint = point;
                Rubber(paintTool, point);
            }
        }

        public void ExecuteStop(ref Bitmap temporary, ref Bitmap current, PaintTool paintTool, Point point)
        {
            _startPoint = new Point(0);
        }

        public void ExecuteMove(ref Bitmap temporary, ref Bitmap current, PaintTool paintTool, Point point)
        {
            using (_graphics = Graphics.FromImage(current))
            {
                Rubber(paintTool,point);
            }
            _startPoint = point;
        }

        private void Rubber(PaintTool paintTool, Point point)
        {
            Pen newPen = new Pen(Color.White, paintTool.Pen.Width);
            _graphics.DrawLine(newPen, _startPoint, point);
        }
    }
}
