using System.Drawing;
using System.Windows.Forms;
using PaintApplication.Model;
using PaintApplication.Model.Commands;
using PaintApplication.Model.FlipItems;
using PaintApplication.Model.MementoItems;
using PaintApplication.Model.RotateItems;
using PaintApplication.View;

namespace PaintApplication.Presenter
{
    class PaintPresenter
    {
        private readonly PaintForm _paintForm;
        private Canvas _currentCanvas;
        private Canvas _temporaryCanvas;
        private readonly PaintTool _paintTool;
        private  IPaintCommand _paintCommand;
        private readonly SaveControler _saveControler;
        private readonly LoadControler _loadControler;
        private Originator _originator;
        private readonly Caretaker _caretaker;

        public PaintPresenter(PaintForm paintForm, PaintTool paintTool)
        {
            _paintForm = paintForm;
            _paintCommand = PaintCommandFactory.GetPaintCommand(PaintToolType.None);
            _paintForm.StartPaintAction += ExecuteStartPaintAction;
            _paintForm.StopPaintAction += ExecuteStopPaintAction;
            _paintForm.ToolAction += ExecuteToolAction;
            _paintForm.MovePaintAction += ExecuteMovePaintAction;
            _paintForm.ColorAction += ExecuteColorAction;
            _paintForm.SizePenAction += ExecuteSizePenAction;
            _paintForm.SizeChangeAction += ExecuteSizeChangeAction;
            _paintForm.SaveAction += ExecuteSaveAction;
            _paintForm.LoadAction += ExecuteLoadAction;
            _paintForm.RotateAction += ExecuteRotateAction;
            _paintForm.FlipAction += ExecuteFlipAction;
            _paintForm.UndoAction += ExecuteUndoAction;
            _paintForm.BrushAction += ExecuteBrushAction;
            
            _paintTool = paintTool;
            _saveControler = new SaveControler();
            _loadControler = new LoadControler();
            _currentCanvas = new Canvas(400, 400);
            _temporaryCanvas = new Canvas(400, 400);
            _caretaker = new Caretaker();
            _originator = new Originator(_currentCanvas.Bitmap, _currentCanvas.Width, _currentCanvas.Height);
        }

        private void ExecuteToolAction(PaintToolType paintToolType)
        {
            _paintCommand = PaintCommandFactory.GetPaintCommand(paintToolType);
            _paintCommand.SnapshotEvent += CreateSnapshot;
        }
        private void ExecuteBrushAction(BrushType brushType)
        {
            _paintTool.SetBrush(brushType);
            ExecuteToolAction(PaintToolType.Brush);
        }
        private void ExecuteColorAction(Color color)
        {
            _paintTool.SetColor(color);
        }
        private void ExecuteSizePenAction(int size)
        {
            _paintTool.SetPenSize(size);
        }
        private void ExecuteSizeChangeAction(int width, int height)
        {
            CreateSnapshot();
            _currentCanvas.Resize(width, height);
            _paintForm.UpdateCanvas(_currentCanvas.Bitmap);
        }
        private void ExecuteStartPaintAction(Point point)
        {
            _paintCommand.ExecuteStart(ref _temporaryCanvas, ref _currentCanvas, _paintTool, point);
            _paintForm.UpdateCanvas(_currentCanvas.Bitmap);

        }
        private void ExecuteMovePaintAction(Point point)
        {
            using (_temporaryCanvas = new Canvas(_currentCanvas))
            {
                _paintCommand.ExecuteMove(ref _temporaryCanvas, ref _currentCanvas, _paintTool, point);
                _paintForm.UpdateCanvas(_temporaryCanvas.Bitmap);
            }
        }
        private void ExecuteStopPaintAction(Point point)
        {
            _paintCommand.ExecuteStop(ref _temporaryCanvas, ref _currentCanvas, _paintTool, point);
            _paintForm.UpdateCanvas(_currentCanvas.Bitmap);
        }
        private void ExecuteRotateAction(RotateTypes rotateTypes)
        {
            CreateSnapshot();
            _currentCanvas.Rotate(rotateTypes);
            _paintForm.UpdateCanvas(_currentCanvas.Bitmap);
        }
        private void ExecuteFlipAction(FlipType flipType)
        {
            CreateSnapshot();
            _currentCanvas.Flip(flipType);
            _paintForm.UpdateCanvas(_currentCanvas.Bitmap);
        }
        private void ExecuteUndoAction()
        {
           // _caretaker.RestoreMemento(_originator);
           // _currentCanvas = _originator.GetBitmap();
           //_paintForm.UpdateCanvas(_currentCanvas);
        }
        private void ExecuteLoadAction(string filePath)
        {
            CreateSnapshot();
            //Bitmap bitmap = _loadControler.LoadBitmapFromFile(_currentCanvas.Bitmap);
            //canvasControl.Size = new Size(bitmap.Width, bitmap.Height);
            //canvasControl.Image = bitmap;
            //_currentCanvas = new Bitmap(canvasControl.Image);
        }
        private void ExecuteSaveAction()
        {
            _saveControler.SavePictureAsBitmap(_currentCanvas.Bitmap);
        }
        public void CreateSnapshot()
        {
            _originator = new Originator(_currentCanvas.Bitmap, _currentCanvas.Width, _currentCanvas.Height);
            _caretaker.SaveMemento(_originator);
        }
        public void RunApp()
        {
            Application.EnableVisualStyles();
            Application.Run(_paintForm);
        }
    }
}
