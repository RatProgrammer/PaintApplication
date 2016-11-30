using System.Drawing;

namespace PaintApplication.Model.RotateItems
{
    class RotateControler
    { 
        public Bitmap RotateLeft90(Bitmap currentBitmap)
        {
            return Rotate(currentBitmap, RotateFlipType.Rotate270FlipNone);
        }
        public Bitmap RotateRight90(Bitmap currentBitmap)
        {
            return Rotate(currentBitmap, RotateFlipType.Rotate90FlipNone);
        }
        public Bitmap Rotate180(Bitmap currentBitmap)
        {
            return Rotate(currentBitmap, RotateFlipType.Rotate180FlipNone);
        }

        private Bitmap Rotate(Bitmap currentBitmap, RotateFlipType rotateFlipType)
        {
            Bitmap bitmapToRotate = new Bitmap(currentBitmap, currentBitmap.Width, currentBitmap.Height);
            bitmapToRotate.RotateFlip(rotateFlipType);
            return bitmapToRotate;
        }
    }
}
