using System.Drawing;
using System.IO;

namespace PaintApplication.Model
{
    class BitmapLoader
    {
        public Bitmap LoadBitmapFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                var bitmap = Image.FromFile(filePath);
                return new Bitmap(bitmap);
            }
            return new Bitmap(400, 400);
        }

    }
}
