using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintApplication.Model
{
    class OperationStake
    {
        public OperationStake()
        {
            Operations = new List<Operation>();
        }

        public List<Operation> Operations { get; set; }

        public void Undo(ref Canvas canvas)
        {
            if (Operations.Count > 0)
            {
                Operations.RemoveAt(Operations.Count-1);
            }
            foreach (var operation in Operations)
            {
                operation.Command.Execute(ref canvas, operation.Tool);
            }
        }
    }
}
