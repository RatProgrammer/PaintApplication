using System;
using System.Drawing;
using System.Windows.Forms;
using PaintApplication.Model;
using PaintApplication.Model.Commands;
using PaintApplication.Model.FlipItems;
using PaintApplication.Model.MementoItems;
using PaintApplication.Model.RotateItems;
using PaintApplication.Model.Utility;
using PaintApplication.View;

namespace PaintApplication.Presenter
{
    class PaintPresenter
    {
        private readonly IPaintForm _paintForm;
        private Canvas _currentCanvas;
        private Canvas _temporaryCanvas;
        private readonly PaintTool _paintTool;
        private  IPaintCommand _paintCommand;
        private readonly SaveControler _saveControler;
        private readonly BitmapLoader _bitmapLoader;
        private Originator _originator;
        private OriginatorFactory _originatorFactory;
        private readonly Caretaker _caretaker;

        public PaintPresenter(IPaintForm paintForm, PaintTool paintTool, CanvasFactory canvasFactory, SaveControler saveControler, BitmapLoader bitmapLoader, Caretaker caretaker, OriginatorFactory originatorFactory)
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
            _saveControler = saveControler;
            _bitmapLoader = bitmapLoader;
            _currentCanvas = canvasFactory(400, 400);
            _temporaryCanvas = canvasFactory(400, 400);
            _caretaker = caretaker;
            _originator = originatorFactory(_currentCanvas.Bitmap, _currentCanvas.Width, _currentCanvas.Height);
            _originatorFactory = originatorFactory;
        }

        private void ExecuteToolAction()
        {
            var paintTool = EnumUtil.ParseEnum<PaintToolType>(_paintForm.ToolType);
            _paintCommand = PaintCommandFactory.GetPaintCommand(paintTool);
            _paintCommand.SnapshotEvent += CreateSnapshot;
        }
        private void ExecuteBrushAction()
        {
            var brushType = EnumUtil.ParseEnum<BrushType>(_paintForm.BrushType);
            _paintForm.ToolType = PaintToolType.Brush.ToString();
            _paintTool.SetBrush(brushType);
        }
        private void ExecuteColorAction()
        {
            _paintTool.SetColor(_paintForm.ColorBrush);
        }
        private void ExecuteSizePenAction()
        {
            _paintTool.SetPenSize(_paintForm.PenSize);
        }
        private void ExecuteSizeChangeAction()
        {
            CreateSnapshot();
            _currentCanvas.Resize(_paintForm.CanvasSizeWidth, _paintForm.CanvasSizeHeight);
            _paintForm.UpdateCanvas(_currentCanvas.Bitmap);
        }
        private void ExecuteStartPaintAction()
        {
            _paintCommand.ExecuteStart(ref _temporaryCanvas, ref _currentCanvas, _paintTool, _paintForm.MouseLocation);
            _paintForm.UpdateCanvas(_currentCanvas.Bitmap);
        }
        private void ExecuteMovePaintAction()
        {
            using (_temporaryCanvas = new Canvas(_currentCanvas))
            {
                _paintCommand.ExecuteMove(ref _temporaryCanvas, ref _currentCanvas, _paintTool, _paintForm.MouseLocation);
                _paintForm.UpdateCanvas(_temporaryCanvas.Bitmap);
            }
        }
        private void ExecuteStopPaintAction()
        {
            _paintCommand.ExecuteStop(ref _temporaryCanvas, ref _currentCanvas, _paintTool, _paintForm.MouseLocation);
            _paintForm.UpdateCanvas(_currentCanvas.Bitmap);
        }
        private void ExecuteRotateAction()
        {
            CreateSnapshot();
            RotateTypes rotateTypes = EnumUtil.ParseEnum<RotateTypes>(_paintForm.RotateType);
            _currentCanvas.Rotate(rotateTypes);
            _paintForm.UpdateCanvas(_currentCanvas.Bitmap);
        }
        private void ExecuteFlipAction()
        {
            CreateSnapshot();
            FlipType flipType = EnumUtil.ParseEnum<FlipType>(_paintForm.FlipType);
            _currentCanvas.Flip(flipType);
            _paintForm.UpdateCanvas(_currentCanvas.Bitmap);
        }
        private void ExecuteUndoAction()
        {
            _caretaker.RestoreMemento(_originator);
            var bitmap = _originator.GetBitmap();
            _currentCanvas.LoadBitmap(bitmap);
            _paintForm.UpdateCanvas(_currentCanvas.Bitmap);
        }
        private void ExecuteLoadAction()
        {
            CreateSnapshot();
            var loadedBitmap = _bitmapLoader.LoadBitmapFromFile(_paintForm.FileLocationName);
            _currentCanvas.LoadBitmap(loadedBitmap);
            _paintForm.UpdateCanvas(_currentCanvas.Bitmap);
        }
        private void ExecuteSaveAction()
        {
            _saveControler.SavePictureAsBitmap(_currentCanvas.Bitmap);
        }
        public void CreateSnapshot()
        {
            _originator = _originatorFactory(_currentCanvas.Bitmap, _currentCanvas.Width, _currentCanvas.Height);
            _caretaker.SaveMemento(_originator);
        }
        public void RunApp()
        {
            Application.EnableVisualStyles();
            Application.Run((Form)_paintForm);
        }
    }
}
