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
                    HatchBrush backwardDiagonalBrush = new HatchBrush(HatchStyle.BackwardDiagonal,color,Color.White);
                    return backwardDiagonalBrush;
                case BrushType.DiagonalBrick:
                    HatchBrush diagonalBrickBrush = new HatchBrush(HatchStyle.DiagonalBrick, color, Color.White);
                    return diagonalBrickBrush;
                case BrushType.CrossBrush:
                     HatchBrush crossBrush = new HatchBrush(HatchStyle.Cross, color, Color.White);
                    return crossBrush;
                case BrushType.SmallConfetti:
                    HatchBrush smalConfettiBrush = new HatchBrush(HatchStyle.SmallConfetti, color, Color.White);
                    return smalConfettiBrush;
                case BrushType.ZigZag:
                    HatchBrush zigzagBrush = new HatchBrush(HatchStyle.ZigZag, color, Color.White);
                    return zigzagBrush;
                case BrushType.LargeCheckerBoard:
                    HatchBrush largeCheckerBoardBrush = new HatchBrush(HatchStyle.LargeCheckerBoard, color, Color.White);
                    return largeCheckerBoardBrush;
                case BrushType.Wave:
                    HatchBrush waveBrush = new HatchBrush(HatchStyle.Wave, color, Color.White);
                    return waveBrush;
                case BrushType.Sphere:
                    HatchBrush sphereBrush = new HatchBrush(HatchStyle.Sphere, color, Color.White);
                    return sphereBrush;
                case BrushType.SolidDiamond:
                    HatchBrush solidDiamondBrush = new HatchBrush(HatchStyle.SolidDiamond, color, Color.White);
                    return solidDiamondBrush;
                case BrushType.Shingle:
                    HatchBrush shingleBrush = new HatchBrush(HatchStyle.Shingle, color, Color.White);
                    return shingleBrush;
                case BrushType.DarkHorizontal:
                    HatchBrush darkHorizontalBrush = new HatchBrush(HatchStyle.DarkHorizontal, color, Color.White);
                    return darkHorizontalBrush;
                case BrushType.LargeConfetti:
                    HatchBrush largeConfettiBrush = new HatchBrush(HatchStyle.LargeConfetti, color, Color.White);
                    return largeConfettiBrush;
                default:
                    throw new ArgumentOutOfRangeException(nameof(brushType), brushType, null);
            }
        }
    }
}