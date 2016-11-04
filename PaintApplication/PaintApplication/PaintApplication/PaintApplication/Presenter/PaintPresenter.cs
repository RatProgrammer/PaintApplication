﻿using System.Drawing;
using System.Windows.Forms;
using PaintApplication.Model;
using PaintApplication.Model.Commands;
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
            _paintTool = paintTool;
            _saveControler = new SaveControler();
            _loadControler = new LoadControler();
            _rotateTypeFactory = new RotateTypeFactory();
            _paintCommand = PaintCommandFactory.GetPaintCommand(PaintToolType.None);
            _currentBitmap = new Bitmap(400,400);
            _temporaryBitmap = new Bitmap(400, 400);
            InitializeBitmap();
        }

        private void ExecuteRotateAction(RotateTypes obj)
        {
            _currentBitmap = _rotateTypeFactory.GetRotateType(obj, _currentBitmap);
            _paintForm.UpdateCanvas(_currentBitmap);
        }


        private void ExecuteLoadAction(CanvasControl canvasControl)
        {
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
            _paintCommand.ExecuteStart(ref _temporaryBitmap, ref _currentBitmap, _paintTool, point);
            _paintForm.UpdateCanvas(_currentBitmap);
        }

        private void ExecuteMovePaintAction(Point point)
        {
            using (_temporaryBitmap = new Bitmap(_currentBitmap))
            {
                _paintCommand.ExecuteMove(ref _temporaryBitmap, ref _currentBitmap, _paintTool, point);
                _paintForm.UpdateCanvas(_temporaryBitmap);
            }
        }

        private void ExecuteStopPaintAction(Point point)
        {
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

        public void RunApp()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(_paintForm);
        }
        
    }
}
