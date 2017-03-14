using System;
using System.Collections.Generic;
using System.Drawing;
using PaintApplication.Model.Utility;

namespace PaintApplication.Model.Commands
{
    class BrushCommand : IPaintCommand
    {
        private List<Point> _rec = new List<Point>();
        public void Execute(ref Canvas canvas, PaintTool paintTool)
        {
            using (var graphics = Graphics.FromImage(canvas.Bitmap))
            {
                _rec.Add(paintTool.EndPoint);
                foreach (var point in _rec)
                {
                    Rectangle rectangle = new Rectangle(point.X, point.Y, 10, 10);
                    graphics.FillEllipse(paintTool.Brush, rectangle);
                }
            }
        }
    }
}
