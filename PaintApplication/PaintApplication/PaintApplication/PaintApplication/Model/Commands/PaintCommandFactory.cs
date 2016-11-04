namespace PaintApplication.Model.Commands
{
    class PaintCommandFactory
    {
        public static IPaintCommand GetPaintCommand(PaintToolType paintToolType)
        {
            switch (paintToolType)
            {
                case PaintToolType.Pencil:
                    return new PencilCommand();
                case PaintToolType.Rubber:
                    return new RubberCommand();
                case PaintToolType.Bucket:
                    return new BucketCommand();
                case PaintToolType.Circle:
                    return new CircleCommand();
                case PaintToolType.Line:
                    return new LineCommand();
                case PaintToolType.Rectangle:
                        return new RectagleCommand();
                default:
                    return new NullObjectCommand();
            }
        }
    }
}
