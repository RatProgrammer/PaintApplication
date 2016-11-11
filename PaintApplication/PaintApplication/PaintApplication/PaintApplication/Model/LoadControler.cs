using System.Drawing;
using System.Windows.Forms;
using PaintApplication.View;

namespace PaintApplication.Model
{
    class LoadControler
    {
        private OpenFileDialog _openFileDialog;
        private CanvasControl canvasControl;

        public LoadControler()
        {
            _openFileDialog = new OpenFileDialog();
        }

        public Bitmap LoadBitmapFromFile(Bitmap bitmap)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return new Bitmap(_openFileDialog.FileName);
            }
            return new Bitmap(bitmap);
        }

    }
}
