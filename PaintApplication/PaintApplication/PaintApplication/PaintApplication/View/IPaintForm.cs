using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintApplication.Model;
using PaintApplication.Model.FlipItems;
using PaintApplication.Model.RotateItems;

namespace PaintApplication.View
{
    interface IPaintForm
    {
        event Action<Point> StartPaintAction;
        event Action<Point> StopPaintAction;
        event Action<PaintToolType> ToolAction;
        event Action<Point> MovePaintAction;
        event Action<Color> ColorAction;
        event Action<int> SizePenAction;
        event Action<int, int> SizeChangeAction;
        event Action SaveAction;
        event Action<string> LoadAction;
        event Action<RotateTypes> RotateAction;
        event Action<FlipType> FlipAction;
        event Action UndoAction;
        event Action<BrushType> BrushAction;

        Point MousePosition { get; set; }
        string Toolaction { get; set; }
        Color Color { get; set; }
        int PenSize { get; set; }
        int CanvasSizeX { get; set; }
        int CanvasSizeY { get; set; }
        string LocationToLoad { get; set; }
        string RotateType { get; set; }
        string FlipType { get; set; }
        string BrushType { get; set; }
    }
}
