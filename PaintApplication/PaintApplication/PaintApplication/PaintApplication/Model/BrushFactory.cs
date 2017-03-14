using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PaintApplication.Model
{
    internal class BrushFactory
    {
        public Brush CreateBrush(HatchStyle hatchStyle, Color color)
        {
            return new HatchBrush(hatchStyle, color, Color.Transparent);
        }
    }
}