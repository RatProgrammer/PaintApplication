using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApplication.Model
{
    class CopyBitmapContoler
    {
        public Bitmap CopyPictureBitmap(Bitmap currentBitmap)
        {
            Bitmap oldBitmap = currentBitmap;
            Rectangle rec = new Rectangle(0, 0, oldBitmap.Width, oldBitmap.Height);
            Bitmap newBitmap = Copy(oldBitmap, rec, currentBitmap);
            //currentBitmap.Dispose();
            currentBitmap = new Bitmap(newBitmap, newBitmap.Width, newBitmap.Height);
            return currentBitmap;
        }

        private Bitmap Copy(Bitmap sourceBitmap, Rectangle section, Bitmap currentBitmap)
        {
            Bitmap bmp = new Bitmap(currentBitmap.Width, currentBitmap.Height);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.FillRectangle(Brushes.White, 0, 0, currentBitmap.Width, currentBitmap.Height);
            graphics.DrawImage(sourceBitmap, 0, 0, section, GraphicsUnit.Pixel);
            graphics.Dispose();

            return bmp;
        }
    }
}
