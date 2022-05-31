using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWProgram.Classes
{
    public abstract class Query
    {
        public abstract bool Response();
    }

    public abstract class QueryWithGammaAndPi : Query
    {
        public State Gamma { get; set; }
        public State Pi { get; set; }

        public QueryWithGammaAndPi()
        {
            Gamma = new State();
            Pi = new State();
        }
    }

    public abstract class QueryWithW : Query
    {
        public Actor W { get; set; }
    }

    public class AlwaysExecutable : Query
    {
        public override string ToString()
        {
            return "Is program always executable?";
        }
        public override bool Response()
        {
            return true;
        }
    }

    public class EverExecutable : Query
    {
        public override string ToString()
        {
            return "Is program ever executable?";
        }
        public override bool Response()
        {
            return true;
        }
    }

    public class AlwaysAccesibleYFromPi : QueryWithGammaAndPi
    {
        public AlwaysAccesibleYFromPi() : base() { }
        public override string ToString()
        {
            return $"Is {Gamma.ToString()} always accessible from {Pi.ToString()} with P?";
        }
        public override bool Response()
        {
            return true;
        }
    }

    public class EverAccesibleYFromPi : QueryWithGammaAndPi
    {
        public EverAccesibleYFromPi() : base() { }

        public override string ToString()
        {
            return $"Is {Gamma.ToString()} always accessible from {Pi.ToString()} with P?";
        }
        public override bool Response()
        {
            return true;
        }
    }

    public class AlwaysWInvolved : QueryWithW
    {
        public override string ToString()
        {
            return $"Always {W.ToString()} involved with P?";
        }
        public override bool Response()
        {
            return true;
        }
    }

    public class EverWInvolved : QueryWithW
    {
        public override string ToString()
        {
            return $"Ever {W.ToString()} involved with P?";
        }
        public override bool Response()
        {
            return true;
        }
    }
}
