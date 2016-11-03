using System.Drawing;

namespace PaintApplication.Model.Commands
{
    class RubberCommand : IPaintCommand
    {
        private Point _startPoint;
        private Graphics _graphics;

        public void ExecuteStart(ref Bitmap temporary, ref Bitmap current, PaintTool paintTool, Point point)
        {
            using (_graphics = Graphics.FromImage(current))
            {
                _startPoint = point;
                Pen newPen = new Pen(Color.White, 10);
                Rectangle rectangle = new Rectangle(point.X, point.Y, 10, 10);
                _graphics.DrawRectangle(newPen, rectangle);
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
                Pen newPen = new Pen(Color.White, 10);
                Rectangle rectangle = new Rectangle(point.X, point.Y, 10, 10);
                _graphics.DrawRectangle(newPen, rectangle);
            }
            _startPoint = point;
        }
    }
}
