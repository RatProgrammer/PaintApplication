using System.Drawing;

namespace PaintApplication.Model.MementoItems
{
    class Memento
    {
        private readonly Bitmap _currentBitmap;
        private readonly int _width;
        private readonly int _height;

        public Memento(Bitmap currentBitmap, int width, int height)
        {
            _currentBitmap = currentBitmap;
            _width = width;
            _height = height;
        }

        public Bitmap GetBitmap()
        {
            return new Bitmap(_currentBitmap);
        }

        public int GetWidth()
        {
            return _width;
        }

        public int GetHeight()
        {
            return _height;
        }
    }
}
