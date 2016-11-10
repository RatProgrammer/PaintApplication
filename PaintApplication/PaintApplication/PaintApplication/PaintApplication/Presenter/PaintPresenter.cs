﻿using System.Drawing;
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
        private Bitmap _currentBitmap;
        private Bitmap _temporaryBitmap;
        private readonly PaintTool _paintTool;
        private  IPaintCommand _paintCommand;
        private readonly SaveControler _saveControler;
        private readonly LoadControler _loadControler;
        private readonly RotateTypeFactory _rotateTypeFactory;
        private readonly FlipTypeFactory _flipTypeFactory;
        private Originator _originator;
        //private Memento _memento;
        private Caretaker _caretaker;

        public PaintPresenter(PaintForm paintForm, PaintTool paintTool)
        {
            _paintForm = paintForm;
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
            _paintTool = paintTool;
            _saveControler = new SaveControler();
            _loadControler = new LoadControler();
            _rotateTypeFactory = new RotateTypeFactory();
            _flipTypeFactory = new FlipTypeFactory();
            _paintCommand = PaintCommandFactory.GetPaintCommand(PaintToolType.None);
            _currentBitmap = new Bitmap(400,400);
            _temporaryBitmap = new Bitmap(400, 400);
            _caretaker = new Caretaker();
            //_memento = new Memento(_currentBitmap,_currentBitmap.Width, _currentBitmap.Height);
            _originator = new Originator(_currentBitmap, _currentBitmap.Width, _currentBitmap.Height);
            InitializeBitmap();
        }

        private void ExecuteUndoAction()
        {
           CreateSnapshot();
            _caretaker.RestoreMemento(_originator);
          // canvasControl.Size = new Size(_originator.GetWidth(), _originator.GetHeight());
            _temporaryBitmap = _originator.GetBitmap();

           //_currentBitmap = new Bitmap(_originator.GetBitmap());
           // _paintForm.UpdateCanvas(_currentBitmap);
           // canvasControl.Image = (Bitmap) _originator.GetBitmap().Clone();
           _currentBitmap = CopyBitmap();
           _paintForm.UpdateCanvas(_currentBitmap);
        }

        private void ExecuteFlipAction(FlipType obj)
        {
            CreateSnapshot();
            _currentBitmap = _flipTypeFactory.GetFlipType(obj, _currentBitmap);
            _paintForm.UpdateCanvas(_currentBitmap);
        }

        private void ExecuteRotateAction(RotateTypes obj)
        {
            CreateSnapshot();
            _currentBitmap = _rotateTypeFactory.GetRotateType(obj, _currentBitmap);
            _paintForm.UpdateCanvas(_currentBitmap);
        }


        private void ExecuteLoadAction(CanvasControl canvasControl)
        {
            CreateSnapshot();
            Bitmap bitmap = _loadControler.LoadBitmapFromFile(_currentBitmap);
            canvasControl.Size = new Size(bitmap.Width, bitmap.Height);
            canvasControl.Image = bitmap;
            _currentBitmap = new Bitmap(canvasControl.Image);
        }

        private void ExecuteSaveAction()
        {
            _saveControler.SavePictureAsBitmap(_currentBitmap);
        }

        private void ExecuteSizeChangeAction(int width, int height)
        {
           CreateSnapshot();
            using (_temporaryBitmap)
            {
                _temporaryBitmap = new Bitmap(width, height);
                Graphics graphics = Graphics.FromImage(_temporaryBitmap);
                graphics.FillRectangle(Brushes.White, 0, 0, width, height);
                graphics.DrawImage(_currentBitmap, 0, 0, _currentBitmap.Width, _currentBitmap.Height);
                _currentBitmap = new Bitmap(_temporaryBitmap);
            }
        }

        private void ExecuteSizePenAction(int size)
        {
            _paintTool.SetPenSize(size);
        }

        private void InitializeBitmap()
        {
            using (Graphics graphics = Graphics.FromImage(_currentBitmap))
            {
                graphics.FillRectangle(Brushes.White, 0, 0, _currentBitmap.Width, _currentBitmap.Height);
            }
        }

        private void ExecuteStartPaintAction(Point point)
        {
            //CreateSnapshot();
            _paintCommand.ExecuteStart(ref _temporaryBitmap, ref _currentBitmap, _paintTool, point);
            _paintForm.UpdateCanvas(_currentBitmap);
        }

        private void ExecuteMovePaintAction(Point point)
        {
            //CreateSnapshot();
            using (_temporaryBitmap = new Bitmap(_currentBitmap))
            {
                _paintCommand.ExecuteMove(ref _temporaryBitmap, ref _currentBitmap, _paintTool, point);
                _paintForm.UpdateCanvas(_temporaryBitmap);
            }
        }

        private void ExecuteStopPaintAction(Point point)
        {
            //CreateSnapshot();
            _paintCommand.ExecuteStop(ref _temporaryBitmap, ref _currentBitmap, _paintTool, point);
            _paintForm.UpdateCanvas(_currentBitmap);
        }

        private void ExecuteToolAction(PaintToolType paintToolType)
        {
            _paintCommand=PaintCommandFactory.GetPaintCommand(paintToolType);
        }

        private void ExecuteColorAction(Color color)
        {
            _paintTool.SetColor(color);
        }

        public void CreateSnapshot()
        {
            _temporaryBitmap = new Bitmap(_currentBitmap);
            _originator = new Originator(_temporaryBitmap, _currentBitmap.Width, _currentBitmap.Height);
            _caretaker = new Caretaker();
            _caretaker.SaveMemento(_originator);
        }

        public Bitmap CopyBitmap()
        {
            CopyBitmapContoler copyBitmapContoler = new CopyBitmapContoler();
            Bitmap bitmap=copyBitmapContoler.CopyPictureBitmap(_temporaryBitmap);
            return bitmap;
        }

        public void RunApp()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(_paintForm);
        }
        
    }
}
