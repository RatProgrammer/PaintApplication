using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PaintApplication.Model
{
    internal class BrushFactory
    {
        public Brush CreateBrush(BrushType brushType, Color color)
        {
            switch (brushType)
            {
                case BrushType.BackwardDiagonal:
                    HatchBrush brush=new HatchBrush(HatchStyle.BackwardDiagonal,color,Color.White);
                    return brush;
                //case BrushType.Brush2: 
                //    HatchBrush brush1 = new HatchBrush(HatchStyle.Cross, color);
                //    return pen;
                //case BrushType.None:
                //    HatchBrush brush2 = new HatchBrush(HatchStyle.Cross, color);
                //    return pen;
                default:
                    throw new ArgumentOutOfRangeException(nameof(brushType), brushType, null);
            }
        }
    }
}