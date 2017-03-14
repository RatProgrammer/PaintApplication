using System.Collections.Generic;
using System.Drawing;

namespace PaintApplication.Model.Commands
{
    class RubberCommand : IPaintCommand
    {
        private readonly List<Point> _points = new List<Point>();
        public void Execute(ref Canvas canvas, PaintTool paintTool)
        {
            using (var graphics = Graphics.FromImage(canvas.Bitmap))
            {
                var pen = new Pen(Color.White, paintTool.Pen.Width);
                _points.Add(paintTool.EndPoint);
                _points.Add(paintTool.EndPoint);
                graphics.DrawLines(pen, _points.ToArray());
            }
        }
    }
}
