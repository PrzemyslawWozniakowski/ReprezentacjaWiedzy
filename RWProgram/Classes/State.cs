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

        public RWLogic.Formula ToLogic()
        {
            if (Fluents == null || Fluents.Count == 0)
                return null;

            var fluents = Fluents.Select(f => f.ToLogic()).ToList();
            var operators = Operators?.Select(o => o.ToLogic())?.ToList();
            return fluents.Count >= 2 && operators?.Count >= 1
                ? new RWLogic.Formula(fluents[0], fluents[1], operators[0])
                : new RWLogic.Formula(fluents[0]);
        }

    }
}
