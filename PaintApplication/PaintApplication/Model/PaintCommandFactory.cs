using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintApplication.Model.Commands;

namespace PaintApplication.Model
{
    class PaintCommandFactory
    {
        public static IPaintCommand GetPaintCommand(PaintToolType paintToolType)
        {
            switch (paintToolType)
            {
                case PaintToolType.Pencil:
                    return new PencilCommand();
                    break;
                case PaintToolType.Rubber:
                    return new RubberCommand();
                    break;
                case PaintToolType.Bucket:
                    return new NullObjectCommand();
                    break;
                case PaintToolType.Circle:
                    return new NullObjectCommand();
                    break;
                case PaintToolType.Line:
                    return new LineCommand();
                default:
                    return new NullObjectCommand();
            }
        }
    }
}
