using System;
using System.Drawing;
using PaintApplication.Model.Utility;

namespace PaintApplication.Model.Commands
{
    class PencilCommand : IPaintCommand
    {
        private Point _previousPoint;
        private Graphics _graphics;

        public event Action SnapshotEvent;

        public void ExecuteStart(ref Canvas temporary, ref Canvas currentCanvas, PaintTool paintTool, Point point)
        {
            SnapshotEvent?.Invoke();
            _previousPoint = LineUtil.SetFirstPoint(point, currentCanvas.Bitmap, paintTool);
        }

        public void ExecuteStop(ref Canvas temporary, ref Canvas current, PaintTool paintTool, Point point)
        {
            _previousPoint = new Point(0, 0);
        }

        public void ExecuteMove(ref Canvas temporary, ref Canvas current, PaintTool paintTool, Point point)
        {
            Point startPoint = point;
            using (_graphics = Graphics.FromImage(current.Bitmap))
            {
                _graphics.DrawLine(paintTool.Pen, startPoint, _previousPoint);
            }
            _previousPoint = point;
        }
    }
}
