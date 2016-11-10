using System.Drawing;

namespace PaintApplication.Model.MementoItems
{
    class Originator
    {
        private Bitmap _currentBitmap;
        private int _width;
        private int _height;

        public Originator(Bitmap currentBitmap, int width, int height)
        {
            _currentBitmap = (Bitmap)currentBitmap.Clone();
            _width = width;
            _height = height;
        }

        public Memento CreateMemento()
        {
            return new Memento(_currentBitmap, _width, _height);
        }

        public void SetMemento(Memento memento)
        {
            _currentBitmap = new Bitmap(memento.GetBitmap());
            _width = memento.GetWidth();
            _height = memento.GetHeight();
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
