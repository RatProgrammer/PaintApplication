using System;
using System.Drawing;

namespace PaintApplication.Model.Commands
{
    class LineCommand:IPaintCommand
    {
        public void Execute(ref Canvas canvas, PaintTool paintTool)
        {
            using (var graphics = Graphics.FromImage(canvas.Bitmap))
            {
                graphics.DrawLine(paintTool.Pen, paintTool.StartPoint, paintTool.EndPoint);
            }
        }
    }
}
