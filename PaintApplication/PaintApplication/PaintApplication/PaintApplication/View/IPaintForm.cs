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
        event Action StartPaintAction;
        event Action StopPaintAction;
        event Action ToolAction;
        event Action MovePaintAction;
        event Action ColorAction;
        event Action SizePenAction;
        event Action SizeChangeAction;
        event Action SaveAction;
        event Action LoadAction;
        event Action RotateAction;
        event Action FlipAction;
        event Action UndoAction;
        event Action BrushAction;

        Point MouseLocation { get; set; }
        string ToolType { get; set; }
        Color ColorBrush { get; set; }
        int PenSize { get; set; }
        int CanvasSizeWidth { get; set; }
        int CanvasSizeHeight { get; set; }
        string FileLocationName { get; set; }
        string RotateType { get; set; }
        string FlipType { get; set; }
        string BrushType { get; set; }


        void UpdateCanvas(Image image);
    }
}
