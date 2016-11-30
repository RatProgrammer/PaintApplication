using System;
using System.Drawing;
using PaintApplication.Model.FlipItems;
using PaintApplication.Model.RotateItems;

namespace PaintApplication.Model
{
    class Canvas : IDisposable
    {
        private Bitmap _bitmap;
        public int Height { get; private set; }
        public int Width { get; private set; }

        public Bitmap Bitmap => _bitmap;

        public Canvas(int height, int width)
        {
            _bitmap = new Bitmap(width, height);
            InitializeBitmap();
            UpdateSize(width, height);
        }

        public Canvas(Canvas canvas)
        {
            _bitmap = new Bitmap(canvas.Bitmap);
        }

        private void UpdateSize(int width, int height)
        {
            Width = width;
            Height = height;
        }

        private void InitializeBitmap()// to Canvas
        {
            using (Graphics graphics = Graphics.FromImage(_bitmap))
            {
                graphics.FillRectangle(Brushes.White, 0, 0, _bitmap.Width, _bitmap.Height);
            }
        }

        public void Resize(int width, int height)
        {
            Bitmap temporaryBitmap = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(temporaryBitmap);
            graphics.FillRectangle(Brushes.White, 0, 0, width, height);
            graphics.DrawImage(_bitmap, 0, 0, _bitmap.Width, _bitmap.Height);
            _bitmap = new Bitmap(temporaryBitmap);
            UpdateSize(width, height);
        }

        public void Dispose()
        {
            _bitmap.Dispose();
            UpdateSize(0, 0);
        }

        public void Rotate(RotateTypes rotateTypes)
        {
            RotateTypeFactory factory = new RotateTypeFactory();
            factory.Rotate(rotateTypes, _bitmap);
        }

        public void Flip(FlipType flipType)
        {
            FlipTypeFactory factory = new FlipTypeFactory();
            factory.Flip(flipType, _bitmap);
        }
    }
}
