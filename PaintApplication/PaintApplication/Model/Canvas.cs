using System.Drawing;

namespace PaintApplication.Presenter
{
    internal class Canvas
    {
        private Bitmap _temporaryImage;
        private Bitmap _currentImage;
        private int Width { get; set; }
        private int High { get; set; }

        public Canvas(int width, int high)
        {
            Width = width;
            High = high;
            _currentImage = new Bitmap(Width, High);
            _temporaryImage = new Bitmap(Width, High);
        }

        public Bitmap GetCurrentBitmap()
        {
            return _currentImage;
        }

        public Bitmap GetTemporaryBitmap()
        {
            return _temporaryImage;
        }

        public void UpdateCurrentImage()
        {
            _currentImage=new Bitmap(_temporaryImage);
        }

        public void ResizeBitmap(int width, int high)
        {
            Width = width;
            High = high;
            Canvas canvas=new Canvas(width,high);
        }

        public void SetCurrentBitmap(Bitmap bitmap)
        {
            _currentImage = new Bitmap(bitmap);
        }
    }
}
