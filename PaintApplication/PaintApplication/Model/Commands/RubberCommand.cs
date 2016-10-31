using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintApplication.Presenter;

namespace PaintApplication.Model.Commands
{
    class RubberCommand:IPaintCommand
    {
        private Point _previousPoint;
        private Graphics _graphics;
        public Canvas ExecuteStart(Canvas canvas, PaintTool paintTool, Point point)
        {
            Bitmap bitmap = canvas.GetCurrentBitmap();
            Point startPoint = point;
            paintTool.Pen = new Pen(Color.White,5);

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
            paintTool.Pen = new Pen(Color.White, 5);
            _graphics = Graphics.FromImage(bitmap);
            _graphics.DrawLine(paintTool.Pen, startPoint, _previousPoint);
            canvas.SetCurrentBitmap(bitmap);
            _previousPoint = new Point(startPoint.X, startPoint.Y);

            return canvas;

        }
    }
}
