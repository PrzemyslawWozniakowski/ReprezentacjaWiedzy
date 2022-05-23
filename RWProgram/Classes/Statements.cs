using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWProgram.Classes
{
    public abstract class Statement
    {
        public override string ToString() { return string.Empty; }
    }

    //Same as FluentAfterActionbyActor but actors and action empty
    public class InitiallyFluent : FluentAfterActionbyActor
    {
        public override string ToString()
        {
            return $"initially {Alpha.ToString()}";
        }

    }

    public class FluentAfterActionbyActor : Statement
    {
        public Fluent Alpha { get; set; }

        public List<Action> Actions { get; set; }

        public List<Actor> Actors { get; set; }
        public override string ToString()
        {
            var str = $"{Alpha} after ";
            for (var i = 0; i < Actors.Count; i++)
                str = str + $"{Actions[i]} by {Actors[i]}";
            return str;
        }

    }

    public class FluentTypicallyAfterActionbyActor : Statement
    {
        public Fluent Alpha { get; set; }

        public List<Action> Actions { get; set; } = new List<Action>();

        public List<Actor> Actors { get; set; } = new List<Actor>();
        public override string ToString()
        {
            var str = $"{Alpha} typically after ";
            for (var i = 0; i < Actors.Count; i++)
                str = str + $"{Actions[i]} by {Actors[i]}";
            return str;
        }

    }

    public class ObservableFluentAfterActionByActor : Statement
    {
        public Fluent Alpha { get; set; }

        public List<Action> Actions { get; set; } = new List<Action>();

        public List<Actor> Actors { get; set; } = new List<Actor>();

        public override string ToString()
        {
            var str = $"observable {Alpha} after ";
            for (var i = 0; i < Actors.Count; i++)
                str = str + $"{Actions[i]} by {Actors[i]}";
            return str;
        }
    }

    public class ActionByActorCausesAlphaIfFluents : Statement
    {
        public Fluent Alpha { get; set; }

        public Action Action { get; set; }

        public Actor Actor { get; set; }

        public List<Fluent> Pi { get; set; }

        public override string ToString()
        {
            return $"{Action} by {Actor} casues {Alpha} if {Pi}";
        }
    }

    public class ActionByActorReleasesFluent1IfFluents : Statement
    {
        public Fluent F { get; set; }

        public Action Action { get; set; }

        public Actor Actor { get; set; }

        public List<Fluent> Pi { get; set; }

        public override string ToString()
        {
            return $"{Action} by {Actor} releases {F} if {Pi}";
        }
    }

    public class ActionByActorTypicallyCausesAlphaIfFluents
    {
        public Fluent Alpha { get; set; }

        public Action Action { get; set; }

        public Actor Actor { get; set; }

        public List<Fluent> Pi { get; set; }

        public override string ToString()
        {
            return $"{Action} by {Actor} typically casues {Alpha} if {Pi}";
        }
    }

    public class ActionByActorTypicallyReleasesFluent1IfFluents
    {
        public Fluent F { get; set; }

        public Action Action { get; set; }

        public Actor Actor { get; set; }

        public List<Fluent> Pi { get; set; }

        public override string ToString()
        {
            return $"{Action} by {Actor} typically releases {F} if {Pi}";
        }
    }

    public class ImpossibleActionByActorIfFluents
    {
        public List<Fluent> Pi { get; set; }

        public Action Action { get; set; }

        public Actor Actor { get; set; }

        public override string ToString()
        {
            return $"impossible {Action} by {Actor} if {Pi}";
        }
    }

    public class AlwaysPi
    {
        public List<Fluent> Pi { get; set; }

        public override string ToString()
        {
            return $"always {Pi}";
        }
    }

    public class NoninertialFluent
    {
        public Fluent Fluent { get; set; }

        public override string ToString()
        {
            return $"noninertial {Fluent}";
        }
    }
}
