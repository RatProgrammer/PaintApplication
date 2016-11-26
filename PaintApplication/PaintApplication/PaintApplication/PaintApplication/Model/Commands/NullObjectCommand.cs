using System;
using System.Drawing;

namespace PaintApplication.Model.Commands
{
    class NullObjectCommand:IPaintCommand
    {
        public event Action SnapshotEvent;

        public void ExecuteStart(ref Bitmap temporary, ref Bitmap current, PaintTool paintTool, Point point)
        {
        }
        public void ExecuteStop(ref Bitmap temporary, ref Bitmap current, PaintTool paintTool, Point point)
        {
        }

        public void ExecuteMove(ref Bitmap temporary, ref Bitmap current, PaintTool paintTool, Point point)
        {
        }
    }
}
