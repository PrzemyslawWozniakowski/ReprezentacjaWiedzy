using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWProgram.Classes
{
    public  class State
    {
        public List<Fluent> Fluents { get; set; }

        public List<LogicOperator> Operators { get; set; }

        public State()
        {
            this.Fluents = new List<Fluent>(); 
            this.Operators = new List<LogicOperator>(); 
        }

        public override string ToString() { return Helpers.GetAlpha(Fluents, Operators); }

    }
}
