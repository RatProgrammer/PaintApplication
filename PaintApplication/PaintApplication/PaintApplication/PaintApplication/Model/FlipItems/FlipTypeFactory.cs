using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintApplication.Model.RotateItems;

namespace PaintApplication.Model.FlipItems
{
    class FlipTypeFactory
    {
        private readonly FlipControler _flipControler = new FlipControler();
        public Bitmap GetFlipType(FlipType flipType, Bitmap currentBitmap)
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
