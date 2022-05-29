using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWProgram.Classes
{
    public class LogicOperator
    {
        public override string ToString() { return string.Empty; }
    }

    public class And : LogicOperator
    {
        public override string ToString() { return "and"; }
    }

    public class Or : LogicOperator
    {
        public override string ToString() { return "or"; }
    }

    public class Implies : LogicOperator
    {
        public override string ToString() { return "→"; }
    }
}
