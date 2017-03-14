namespace PaintApplication.Model.Commands
{
    internal interface IPaintCommand
    {
        void Execute(ref Canvas canvas, PaintTool paintTool);
    }
}