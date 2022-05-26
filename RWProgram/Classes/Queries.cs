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
        public List<Fluent> Gamma { get; set; }
        public List<Fluent> Pi { get; set; }
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
        public override string ToString()
        {
            return $"Is {string.Join(", ", Gamma.Select(g => g.ToString()))} always accessible from {string.Join(", ", Pi.Select(p => p.ToString()))} with P?";
        }
        public override bool Response()
        {
            return true;
        }
    }

    public class EverAccesibleYFromPi : QueryWithGammaAndPi
    {
        public override string ToString()
        {
            return $"Is {string.Join(", ", Gamma.Select(g => g?.ToString()))} always accessible from {string.Join(", ", Pi.Select(p => p?.ToString()))} with P?";
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
