using System;
using System.Drawing;

namespace PaintApplication.Model.FlipItems
{
    class FlipTypeFactory
    {
        private readonly FlipControler _flipControler = new FlipControler();
        public Bitmap Flip(FlipType flipType, Bitmap currentBitmap)
        {
            switch (flipType)
            {
                case FlipType.Horizontal:
                    return _flipControler.FlipHorizontal(currentBitmap);
                case FlipType.VerticalMenuItem:
                    return _flipControler.FlipVertical(currentBitmap);
                default:
                    throw new ArgumentOutOfRangeException(nameof(flipType), flipType, null);
            }
        }
    }
}
