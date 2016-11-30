using System;
using System.Drawing;

namespace PaintApplication.Model
{
    class RectangleUtil
    {
        public static Point GetLocation( Point startPoint, Point endPoint)
        {
            return new Point(Math.Min(startPoint.X, endPoint.X), Math.Min(startPoint.Y, endPoint.Y));
        }

        public static Size GetSize(Point startPoint, Point endPoint)
        {
            return new Size(Math.Abs(startPoint.X - endPoint.X), Math.Abs(startPoint.Y - endPoint.Y));
        }
    }
}
