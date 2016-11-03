using System.Drawing;
using PaintApplication.Presenter;

namespace PaintApplication.Model.Commands
{
    internal interface IPaintCommand
    {
        void ExecuteStart(ref Bitmap temporary, ref Bitmap current, PaintTool paintTool, Point point);
        void ExecuteStop(ref Bitmap temporary, ref Bitmap current, PaintTool paintTool,Point point);
        void ExecuteMove(ref Bitmap temporary, ref Bitmap current, PaintTool paintTool, Point point);
    }
}