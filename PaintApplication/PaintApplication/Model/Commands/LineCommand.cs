using System.Drawing;
using PaintApplication.Presenter;

namespace PaintApplication.Model.Commands
{
    class LineCommand:IPaintCommand
    {
        private Point _previousPoint;
        private Graphics _graphics;
        public Canvas ExecuteStart(Canvas canvas, PaintTool paintTool, Point point)
        {
            Bitmap bitmap = canvas.GetCurrentBitmap();
            Point startPoint = point;
                bitmap.SetPixel(startPoint.X, startPoint.Y, paintTool.Color);

            canvas.SetCurrentBitmap(bitmap);
            _previousPoint = new Point(startPoint.X, startPoint.Y);
            return canvas;
        }

        public Canvas ExecuteStop(Canvas canvas, PaintTool paintTool, Point point)
        {
            _previousPoint = new Point(0, 0);
            return canvas;
        }

        public Canvas ExecuteMove(Canvas canvas, PaintTool paintTool, Point point)
        {
            Bitmap bitmap = canvas.GetCurrentBitmap();
            Point startPoint = point;
            _graphics = Graphics.FromImage(bitmap);
            _graphics.DrawLine(paintTool.Pen, startPoint, _previousPoint);
            canvas.SetCurrentBitmap(bitmap);
            _previousPoint = new Point(startPoint.X, startPoint.Y);
            return canvas;
        }
    }
}
