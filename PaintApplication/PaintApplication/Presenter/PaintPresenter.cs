using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using PaintApplication.View;

namespace PaintApplication.Presenter
{
    class PaintPresenter
    {
        private readonly PaintForm _paintForm;
        private Bitmap _temporaryImage;
        private Bitmap _actualImage;
    


        private Point startPoint=new Point(0,0);
        private Point endPoint=new Point(0,0);
        private Graphics graphics;


        public PaintPresenter(PaintForm paintForm)
        {
            _paintForm = paintForm;
            _paintForm.StartPaintAction += ExecuteStartPaintAction;
            _paintForm.StopPaintAction += ExecuteStopPaintAction;

            _temporaryImage = new Bitmap(433,319);
            _actualImage = new Bitmap(433,319);
        }

        private void ExecuteStopPaintAction(MouseEventArgs e)
        {
            startPoint.X = 0;
            startPoint.Y = 0;
            endPoint.X = 0;
            endPoint.Y=0;
        }

        private void ExecuteStartPaintAction(MouseEventArgs e)
        {
            startPoint.X = e.X;
            startPoint.Y = e.Y;
            if (endPoint.X == 0 && endPoint.Y == 0)
            {
                _actualImage.SetPixel(startPoint.X, startPoint.Y, Color.Black);
                _paintForm.UpdateCanvas(_actualImage);
            }
            else
            {
                startPoint = e.Location;
                Pen pen = new Pen(Color.Black, 2);
                graphics = Graphics.FromImage(_actualImage);
                graphics.DrawLine(pen, startPoint, endPoint);
                _paintForm.UpdateCanvas(_actualImage);
            }
            endPoint = startPoint;
        }

        public void RunApp()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(_paintForm);
        }
        
    }
}
