using System.Drawing;

namespace PaintApplication.Model.Utility
{
    class LineUtil
    {
        public static Point SetFirstPoint(Point point, Bitmap currentBitmap, PaintTool paintTool)
        {
            Point startPoint = point;
            currentBitmap.SetPixel(startPoint.X, startPoint.Y, paintTool.Color);
            return point;
        }
    }
}
