using System.Drawing;

namespace PaintApplication.Model.RotateItems
{
    class RotateControler
    { 
        public Bitmap RotateLeft90(Bitmap currentBitmap)
        {
            Bitmap bitmapToRotate=new Bitmap(currentBitmap,currentBitmap.Width,currentBitmap.Height);
            bitmapToRotate.RotateFlip(RotateFlipType.Rotate270FlipNone);
            return bitmapToRotate;
        }
        public Bitmap RotateRight90(Bitmap currentBitmap)
        {
            Bitmap bitmapToRotate = new Bitmap(currentBitmap, currentBitmap.Width, currentBitmap.Height);
            bitmapToRotate.RotateFlip(RotateFlipType.Rotate90FlipNone);
            return bitmapToRotate;
        }
        public Bitmap Rotate180(Bitmap currentBitmap)
        {
            Bitmap bitmapToRotate = new Bitmap(currentBitmap, currentBitmap.Width, currentBitmap.Height);
            bitmapToRotate.RotateFlip(RotateFlipType.Rotate180FlipNone);
            return bitmapToRotate;
        }
    }
}
