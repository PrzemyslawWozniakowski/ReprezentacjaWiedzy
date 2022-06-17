using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicExpressionsParser;
namespace RWProgram.Classes
{
    public  class State
    {
        public LogicalExpressionRoot LogicalExpressionRoot;
        public string LogicalExpressionString;

        public State()
        {
            this.LogicalExpressionRoot = null;
            this.LogicalExpressionString = string.Empty;
        }

        public State(string LogicalExpressionString)
        {
            if (string.IsNullOrEmpty(LogicalExpressionString.Trim()))
            {
                this.LogicalExpressionRoot = null;
                this.LogicalExpressionString = string.Empty;
            }
            else
            {
                this.LogicalExpressionRoot = Parser.Parse(LogicalExpressionString);
                this.LogicalExpressionString = LogicalExpressionString;
            }
        }

        public State(LogicalExpressionRoot logicalExpressionRoot, string logicalExpressionString)
        {
            this.LogicalExpressionRoot = logicalExpressionRoot;
            this.LogicalExpressionString = logicalExpressionString;
        }

        public override string ToString() { return LogicalExpressionString; }

        public RWLogic.Formula ToLogic()
        {
            if (string.IsNullOrEmpty(this.LogicalExpressionString))
                return new RWLogic.Formula();

            return new RWLogic.Formula(LogicalExpressionRoot);
        }

    }
}
