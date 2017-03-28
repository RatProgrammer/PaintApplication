using System.Windows.Input;
using PaintApplication.Model.Commands;

namespace PaintApplication.Model
{
    class Operation
    {
        public Operation(PaintTool paintTool, IPaintCommand command)
        {
            Tool = paintTool;
            Command = command;
        }

        public PaintTool Tool { get; }

        public IPaintCommand Command { get; }
    }
}
