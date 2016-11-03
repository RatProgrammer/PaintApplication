using System.Drawing;

namespace PaintApplication.Model.Commands
{
    class LineCommand:IPaintCommand
    {
        private Point _startPoint;

        public void ExecuteStart(ref Bitmap temporary, ref Bitmap current, ref PaintTool paintTool, Point point)
        {
            _startPoint = point;
        }

        public void ExecuteStop(ref Bitmap temporary, ref Bitmap current, ref PaintTool paintTool, Point point)
        {
            using (Graphics graphics = Graphics.FromImage(current))
            {
                graphics.DrawLine(paintTool.Pen, _startPoint, point);
            }
        }

        public void ExecuteMove(ref Bitmap temporary, ref Bitmap current, ref PaintTool paintTool, Point point)
        {
            using (Graphics graphics = Graphics.FromImage(temporary))
            {
                graphics.DrawLine(paintTool.Pen, _startPoint, point);
            }
        }
    }
}
