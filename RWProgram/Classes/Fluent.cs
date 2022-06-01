using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWProgram.Classes
{
    public class Fluent
    {
        public int Index { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class NegatedFluent : Fluent
    {
        public Fluent Original { get; set; }
        public override string ToString()
        {
            return "not " + Name;
        }
    }
}
