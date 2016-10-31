﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintApplication.Presenter;

namespace PaintApplication.Model.Commands
{
    class PencilCommand : IPaintCommand
    {
        private Point _previousPoint;
        private Graphics _graphics;

        public Canvas ExecuteStart(Canvas canvas, PaintTool paintTool, Point point)
        {
            Bitmap bitmap = canvas.GetCurrentBitmap();
            Point startPoint = point;
            if (_previousPoint.X == 0 && _previousPoint.Y == 0)
            {
                bitmap.SetPixel(startPoint.X, startPoint.Y, paintTool.Color);
            }
            else
            {
               _graphics = Graphics.FromImage(bitmap);
               _graphics.DrawLine(paintTool.Pen, startPoint, _previousPoint);
            }
            canvas.SetCurrentBitmap(bitmap);
            _previousPoint = new Point(startPoint.X, startPoint.Y);
            return canvas;
        }

        public Canvas ExecuteStop(Canvas canvas, PaintTool paintTool, Point point)
        {
            _previousPoint = new Point(0, 0);
            return canvas;
        }
    }
}