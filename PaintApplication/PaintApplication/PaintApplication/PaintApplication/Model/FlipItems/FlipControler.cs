using System.Drawing;

namespace PaintApplication.Model.FlipItems
{
    class FlipControler
    {
        public Bitmap FlipHorizontal(Bitmap currentBitmap)
        {
            Bitmap bitmapToFlip = new Bitmap(currentBitmap, currentBitmap.Width, currentBitmap.Height);
            bitmapToFlip.RotateFlip(RotateFlipType.Rotate180FlipX);
            return bitmapToFlip;
        }
        public Bitmap FlipVertical(Bitmap currentBitmap)
        {
            Bitmap bitmapToFlip = new Bitmap(currentBitmap, currentBitmap.Width, currentBitmap.Height);
            bitmapToFlip.RotateFlip(RotateFlipType.Rotate180FlipY);
            return bitmapToFlip;
        }
    }
}
