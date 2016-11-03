using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintApplication.Model.Commands;
using PaintApplication.Presenter;

namespace PaintApplication.Model
{
    class NullObjectCommand:IPaintCommand
    {
        public Canvas ExecuteStart(Canvas canvas, PaintTool paintTool, Point point)
        {
            return canvas;
        }

        public Canvas ExecuteStop(Canvas canvas, PaintTool paintTool, Point point)
        {
            return canvas;
        }

        public Canvas ExecuteMove(Canvas canvas, PaintTool paintTool, Point point)
        {
            throw new NotImplementedException();
        }
    }
}
