using System;
using System.Drawing;

namespace PaintApplication.Model.Commands
{
    internal interface IPaintCommand
    {
        event Action SnapshotEvent;
        void ExecuteStart(ref Bitmap temporary, ref Bitmap current, PaintTool paintTool, Point point);
        void ExecuteStop(ref Bitmap temporary, ref Bitmap current, PaintTool paintTool,Point point);
        void ExecuteMove(ref Bitmap temporary, ref Bitmap current, PaintTool paintTool, Point point);
        
    }
}