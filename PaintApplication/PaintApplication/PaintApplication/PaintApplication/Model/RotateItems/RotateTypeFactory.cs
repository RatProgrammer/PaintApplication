using System;
using System.Drawing;

namespace PaintApplication.Model.RotateItems
{
    class RotateTypeFactory
    {
        private readonly RotateControler _rotateControler=new RotateControler();
        public  Bitmap GetRotateType(RotateTypes rotateTypes,Bitmap currentBitmap)
        {
            switch (rotateTypes)
            {
                case RotateTypes.Left90:
                    return _rotateControler.RotateLeft90(currentBitmap);
                case RotateTypes.Right90MenuItem:
                    return _rotateControler.RotateRight90(currentBitmap);
                case RotateTypes.Right180:
                    return _rotateControler.Rotate180(currentBitmap);
                default:
                    throw new ArgumentOutOfRangeException(nameof(rotateTypes), rotateTypes, null);
            }
        }
    }
}
