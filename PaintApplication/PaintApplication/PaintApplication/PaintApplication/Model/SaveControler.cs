using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace PaintApplication.Model
{
    class SaveControler
    {
       private readonly SaveFileDialog _saveFileDialog;

        public SaveControler()
        {
            _saveFileDialog = new SaveFileDialog();
        }

        public void SavePictureAsBitmap(Bitmap bitmap)
        {
            _saveFileDialog.Filter = "Bitmap Image|*.bmp";
            _saveFileDialog.Title = "Save an image file";
            _saveFileDialog.ShowDialog();
            if (_saveFileDialog.FileName != "")
            {
                CreateFile(bitmap);
            }
        }

        private void CreateFile(Bitmap bitmap)
        {
            FileStream fileStream = (FileStream)_saveFileDialog.OpenFile();
            bitmap.Save(fileStream, System.Drawing.Imaging.ImageFormat.Bmp);
            fileStream.Close();
        }
    }
}
