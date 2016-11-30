using System;
using System.Drawing;

namespace PaintApplication.Model.Commands
{
    internal interface IPaintCommand
    {
        event Action SnapshotEvent;
        void ExecuteStart(ref Canvas temporary, ref Canvas currentCanvas, PaintTool paintTool, Point point);
        void ExecuteStop(ref Canvas temporary, ref Canvas current, PaintTool paintTool,Point point);
        void ExecuteMove(ref Canvas temporary, ref Canvas current, PaintTool paintTool, Point point);
        
    }
}