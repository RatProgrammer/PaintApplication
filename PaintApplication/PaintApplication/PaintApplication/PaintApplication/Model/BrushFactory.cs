using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PaintApplication.Model
{
    internal class BrushFactory
    {
        private readonly Color backColor = Color.Transparent;
        public Brush CreateBrush(BrushType brushType, Color color)
        {
            switch (brushType)
            {
                case BrushType.BackwardDiagonal:
                    HatchBrush backwardDiagonalBrush = new HatchBrush(HatchStyle.BackwardDiagonal,color, backColor);
                    return backwardDiagonalBrush;
                case BrushType.DiagonalBrick:
                    HatchBrush diagonalBrickBrush = new HatchBrush(HatchStyle.DiagonalBrick, color, backColor);
                    return diagonalBrickBrush;
                case BrushType.CrossBrush:
                     HatchBrush crossBrush = new HatchBrush(HatchStyle.Cross, color, backColor);
                    return crossBrush;
                case BrushType.SmallConfetti:
                    HatchBrush smalConfettiBrush = new HatchBrush(HatchStyle.SmallConfetti, color, backColor);
                    return smalConfettiBrush;
                case BrushType.ZigZag:
                    HatchBrush zigzagBrush = new HatchBrush(HatchStyle.ZigZag, color, backColor);
                    return zigzagBrush;
                case BrushType.LargeCheckerBoard:
                    HatchBrush largeCheckerBoardBrush = new HatchBrush(HatchStyle.LargeCheckerBoard, color, backColor);
                    return largeCheckerBoardBrush;
                case BrushType.Wave:
                    HatchBrush waveBrush = new HatchBrush(HatchStyle.Wave, color, backColor);
                    return waveBrush;
                case BrushType.Sphere:
                    HatchBrush sphereBrush = new HatchBrush(HatchStyle.Sphere, color, backColor);
                    return sphereBrush;
                case BrushType.SolidDiamond:
                    HatchBrush solidDiamondBrush = new HatchBrush(HatchStyle.SolidDiamond, color, backColor);
                    return solidDiamondBrush;
                case BrushType.Shingle:
                    HatchBrush shingleBrush = new HatchBrush(HatchStyle.Shingle, color, backColor);
                    return shingleBrush;
                case BrushType.DarkHorizontal:
                    HatchBrush darkHorizontalBrush = new HatchBrush(HatchStyle.DarkHorizontal, color, backColor);
                    return darkHorizontalBrush;
                case BrushType.LargeConfetti:
                    HatchBrush largeConfettiBrush = new HatchBrush(HatchStyle.LargeConfetti, color, backColor);
                    return largeConfettiBrush;
                default:
                    throw new ArgumentOutOfRangeException(nameof(brushType), brushType, null);
            }
        }
    }
}