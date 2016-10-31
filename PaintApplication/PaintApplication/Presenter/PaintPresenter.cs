using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using PaintApplication.Model;
using PaintApplication.Model.Commands;
using PaintApplication.View;

namespace PaintApplication.Presenter
{
    class PaintPresenter
    {
        private readonly PaintForm _paintForm;
        private Canvas _canvas;
        private readonly PaintTool _paintTool;
        private  IPaintCommand _paintCommand;

        public PaintPresenter(PaintForm paintForm, Canvas canvas, PaintTool paintTool)
        {
            _paintForm = paintForm;
            _paintForm.StartPaintAction += ExecuteStartPaintAction;
            _paintForm.StopPaintAction += ExecuteStopPaintAction;
            _paintForm.ToolAction += ExecuteToolAction;
            _paintForm.MovePaintAction += ExecuteMovePaintAction;
            _canvas = canvas;
            _paintTool = paintTool;
            _paintCommand = PaintCommandFactory.GetPaintCommand(PaintToolType.None);
        }

        private void ExecuteMovePaintAction(Point obj)
        {
            _canvas = _paintCommand.ExecuteMove(_canvas, _paintTool, obj);
            _paintForm.UpdateCanvas(_canvas.GetCurrentBitmap());
        }

        private void ExecuteToolAction(PaintToolType paintToolType)
        {
            _paintCommand=PaintCommandFactory.GetPaintCommand(paintToolType);
            _paintTool.Color = Color.Black;
            _paintTool.Pen = new Pen(Color.Black, 1);
        }

        private void ExecuteStopPaintAction(Point point)
        {
            _canvas = _paintCommand.ExecuteStop(_canvas, _paintTool, point);
            _paintForm.UpdateCanvas(_canvas.GetCurrentBitmap());
        }

        private void ExecuteStartPaintAction(Point point)
        {
            _canvas = _paintCommand.ExecuteStart(_canvas, _paintTool, point);
            _paintForm.UpdateCanvas(_canvas.GetCurrentBitmap());
        }

        public void RunApp()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(_paintForm);
        }
        
    }
}
