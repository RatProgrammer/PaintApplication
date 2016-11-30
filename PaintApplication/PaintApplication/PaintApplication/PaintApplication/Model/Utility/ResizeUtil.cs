using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintApplication.Model.Utility
{
    class ResizeUtil
    {
        public static void Resize(Bitmap temporaryBitmap, Bitmap currentBitmap, int width, int height)
        {
            Graphics graphics = Graphics.FromImage(temporaryBitmap);
            graphics.FillRectangle(Brushes.White, 0, 0, width, height);
            graphics.DrawImage(currentBitmap, 0, 0, currentBitmap.Width, currentBitmap.Height);
        }
    }
}
