using System.Drawing;
using PaintApplication.Presenter;

namespace PaintApplication.Model.Commands
{
    internal interface IPaintCommand
    {
        Canvas ExecuteStart(Canvas canvas, PaintTool paintTool, Point point);
        Canvas ExecuteStop(Canvas canvas, PaintTool paintTool,Point point);
        Canvas ExecuteMove(Canvas canvas, PaintTool paintTool, Point point);
    }
}