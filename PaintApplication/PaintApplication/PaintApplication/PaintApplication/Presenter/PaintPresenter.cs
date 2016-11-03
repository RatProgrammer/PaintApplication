﻿using System;
using System.Drawing;
using System.Drawing.Imaging;
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
        private Bitmap _currentBitmap;
        private Bitmap _temporaryBitmap;
        private readonly PaintTool _paintTool;
        private  IPaintCommand _paintCommand;

        public PaintPresenter(PaintForm paintForm, PaintTool paintTool)
        {
            _paintForm = paintForm;
            _paintForm.StartPaintAction += ExecuteStartPaintAction;
            _paintForm.StopPaintAction += ExecuteStopPaintAction;
            _paintForm.ToolAction += ExecuteToolAction;
            _paintForm.MovePaintAction += ExecuteMovePaintAction;
            _paintTool = paintTool;
            _paintCommand = PaintCommandFactory.GetPaintCommand(PaintToolType.None);
            _currentBitmap = new Bitmap(400,400);
            _temporaryBitmap = new Bitmap(400, 400);
            InitializeBitmap();
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
            _paintTool.Color = Color.Black;
            _paintTool.Pen = new Pen(Color.Black, 1);

        }

        public void RunApp()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(_paintForm);
        }
        
    }
}