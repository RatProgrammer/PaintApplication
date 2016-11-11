using System.Drawing;
using System.Drawing.Drawing2D;
using PaintApplication.Model.Commands;

namespace PaintApplication.Model
{
    class BrushCommand:IPaintCommand
    {
        private readonly BrushFactory brushFactory;
        private Point _previousPoint;
        private Graphics _graphics;
        private Brush _brush;
        public BrushCommand()
        {
        }

        public void ExecuteStart(ref Bitmap temporary, ref Bitmap current, PaintTool paintTool, Point point)
        {
            
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
            using (_graphics = Graphics.FromImage(current))
            {
                Rectangle rectangle = new Rectangle(point.X, point.Y, 10, 10);
                _graphics.FillEllipse(paintTool.Brush, rectangle);

            }
        }
    }
}
