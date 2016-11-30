using System.Drawing;

namespace PaintApplication.Model.FlipItems
{
    class FlipControler
    {
        public Bitmap FlipHorizontal(Bitmap currentBitmap)
        {
            return FlipBitmap(RotateFlipType.Rotate180FlipX, currentBitmap);
        }
        public Bitmap FlipVertical(Bitmap currentBitmap)
        {
            return FlipBitmap(RotateFlipType.Rotate180FlipY, currentBitmap);
        }

        private Bitmap FlipBitmap(RotateFlipType rotateFlipType, Bitmap currentBitmap)
        {
            Bitmap bitmapToFlip = new Bitmap(currentBitmap, currentBitmap.Width, currentBitmap.Height);
            bitmapToFlip.RotateFlip(rotateFlipType);
            return bitmapToFlip;
        }
    }
}
