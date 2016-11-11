using System.Drawing;
using System.Windows.Forms;

namespace PaintApplication.Model
{
    class LoadControler
    {
        private readonly OpenFileDialog _openFileDialog;

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
