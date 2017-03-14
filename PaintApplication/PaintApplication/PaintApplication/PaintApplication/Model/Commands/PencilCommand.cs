using System.Collections.Generic;
using System.Drawing;

namespace PaintApplication.Model.Commands
{
    class PencilCommand : IPaintCommand
    {
        private readonly List<Point> _points = new List<Point>();

        public void Execute(ref Canvas canvas, PaintTool paintTool)
        {
            using (var graphics = Graphics.FromImage(canvas.Bitmap))
            {
                _points.Insert(0, paintTool.StartPoint);
                _points.Add(paintTool.EndPoint);
                graphics.DrawLines(paintTool.Pen, _points.ToArray());
            }
        }
    }
}
