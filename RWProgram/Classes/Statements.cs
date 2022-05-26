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

    public abstract class ConditionStatement : Statement
    {
        public List<Fluent> Pi { get; set; }

        public ConditionStatement(List<Fluent> Pi)
        {
            this.Pi = Pi == null ? new List<Fluent>() : Pi.Where(a => a != null).ToList();
        }
    }

    public abstract class ConditionActionByActorStatement : ConditionStatement
    {
        public Action Action { get; set; }

        public Actor Actor { get; set; }

        public ConditionActionByActorStatement(Action Action, Actor Actor, List<Fluent> Pi) : base(Pi)
        {
            this.Action = Action;
            this.Actor = Actor;
        }
    }

    public abstract class StatementAfterActionByUser : Statement
    {
        public List<Action> Actions { get; set; }

        public List<Actor> Actors { get; set; }

        public StatementAfterActionByUser(List<Action> Actions, List<Actor> Actors)
        {
            this.Actions = Actions == null ? new List<Action>() : Actions.Where(a => a != null).ToList();
            this.Actors = Actors == null ? new List<Actor>() : Actors.Where(a => a != null).ToList();
        }

    }

    //Same as FluentAfterActionbyActor but actors and action empty
    public class InitiallyFluent : FluentAfterActionbyActor
    {
        public InitiallyFluent(Fluent Alpha) : base(Alpha, null, null)
        { }

        public override string ToString()
        {
            return $"initially {Alpha.ToString()}";
        }

    }

    public class FluentAfterActionbyActor : StatementAfterActionByUser
    {
        public Fluent Alpha { get; set; }

        public FluentAfterActionbyActor(Fluent Alpha, List<Action> Actions, List<Actor> Actors) : base(Actions, Actors) 
        {
            this.Alpha = Alpha; 
        }

        public override string ToString()
        {
            var str = $"{Alpha} after";
            for (var i = 0; i < Actors.Count; i++)
            {
                var comma = i != 0 ? "," : "";
                str = str + $"{comma} {Actions[i]} by {Actors[i]}";
            }
            return str;
        }

    }

    public class FluentTypicallyAfterActionbyActor : StatementAfterActionByUser
    {
        public Fluent Alpha { get; set; }

        public FluentTypicallyAfterActionbyActor(Fluent Alpha, List<Action> Actions, List<Actor> Actors) : base(Actions, Actors)
        {
            this.Alpha = Alpha;
        }

        public override string ToString()
        {
            var str = $"{Alpha} typically after";
            for (var i = 0; i < Actors.Count; i++)
            {
                var comma = i != 0 ? "," : "";
                str = str + $"{comma}  {Actions[i]} by {Actors[i]}";
            }
            return str;
        }

    }

    public class ObservableFluentAfterActionByActor : StatementAfterActionByUser
    {
        public Fluent Alpha { get; set; }

        public ObservableFluentAfterActionByActor(Fluent Alpha, List<Action> Actions, List<Actor> Actors) : base(Actions, Actors)
        {
            this.Alpha = Alpha;
        }

        public override string ToString()
        {
            var str = $"observable {Alpha} after";
            for (var i = 0; i < Actors.Count; i++)
            {
                var comma = i != 0 ? "," : "";
                str = str + $"{comma}  {Actions[i]} by {Actors[i]}";
            }
            return str;
        }
    }

    public class ActionByActorCausesAlphaIfFluents : ConditionActionByActorStatement
    {
        public Fluent Alpha { get; set; }


        public ActionByActorCausesAlphaIfFluents(Fluent Alpha, Action Action, Actor Actor, List<Fluent> Pi) : base(Action ,Actor, Pi)
        {
            this.Alpha = Alpha;
        }

        public override string ToString()
        {
            return $"{Action} by {Actor} casues {Alpha} if {string.Join(",", Pi.Select(p => p.Name))}";
        }
    }

    public class ActionByActorReleasesFluent1IfFluents : ConditionActionByActorStatement
    {
        public Fluent F { get; set; }

        public ActionByActorReleasesFluent1IfFluents(Fluent F, Action Action, Actor Actor, List<Fluent> Pi) : base(Action ,Actor, Pi)
        {
            this.F = F;
        }

        public override string ToString()
        {
            return $"{Action} by {Actor} releases {F} if {string.Join(",", Pi.Select(p => p.Name))}";
        }
    }

    public class ActionByActorTypicallyCausesAlphaIfFluents : ConditionActionByActorStatement
    {
        public Fluent Alpha { get; set; }

        public ActionByActorTypicallyCausesAlphaIfFluents(Fluent Alpha, Action Action, Actor Actor, List<Fluent> Pi) : base(Action, Actor, Pi)
        {
            this.Alpha = Alpha;
        }

        public override string ToString()
        {
            return $"{Action} by {Actor} typically casues {Alpha} if {string.Join(",", Pi.Select(p => p.Name))}";
        }
    }

    public class ActionByActorTypicallyReleasesFluent1IfFluents : ConditionActionByActorStatement
    {
        public Fluent F { get; set; }

        public ActionByActorTypicallyReleasesFluent1IfFluents(Fluent F, Action Action, Actor Actor, List<Fluent> Pi) : base(Action, Actor, Pi)
        {
            this.F = F;
        }

        public override string ToString()
        {
            return $"{Action} by {Actor} typically releases {F} if {string.Join(",", Pi.Select(p => p.Name))}";
        }
    }

    public class ImpossibleActionByActorIfFluents : ConditionActionByActorStatement
    {
        public ImpossibleActionByActorIfFluents(Action Action, Actor Actor, List<Fluent> Pi) : base(Action, Actor, Pi) { }

        public override string ToString()
        {
            var str = $"impossible {Action} by {Actor}";
            if (Pi == null || Pi.Count == 0) return str;
            return $"{str} if {string.Join(",", Pi.Select(p => p.Name))}";
        }
    }

    public class AlwaysPi : ConditionStatement
    {
        public AlwaysPi(List<Fluent> Pi) : base(Pi) { }
        public override string ToString()
        {
            if (Pi == null || Pi.Count == 0) return string.Empty;

            return $"always {string.Join(", ", Pi.Select(p => p?.Name))}";
        }
    }

    public class NoninertialFluent : Statement
    {
        public Fluent Fluent { get; set; }

        public NoninertialFluent(Fluent Fluent)
        {
            this.Fluent = Fluent;
        }

        public override string ToString()
        {
            return $"noninertial {Fluent}";
        }
    }
}
