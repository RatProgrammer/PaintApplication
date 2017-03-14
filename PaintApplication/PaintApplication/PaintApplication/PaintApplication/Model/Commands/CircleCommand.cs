using System;
using System.Drawing;

namespace PaintApplication.Model.Commands
{
    class CircleCommand : IPaintCommand
    {
        private Rectangle _rectangle;

        public void Execute(ref Canvas canvas, PaintTool paintTool)
        {
            using (var graphics = Graphics.FromImage(canvas.Bitmap))
            {
                _rectangle.Location = RectangleUtil.GetLocation(paintTool.StartPoint, paintTool.EndPoint);
                _rectangle.Size = RectangleUtil.GetSize(paintTool.StartPoint, paintTool.EndPoint);
                graphics.DrawEllipse(paintTool.Pen, _rectangle);
            }
        }
    }
}
