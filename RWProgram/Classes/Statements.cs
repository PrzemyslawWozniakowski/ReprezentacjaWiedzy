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

        public State Pi { get; set; }

        public ConditionStatement(List<Fluent> Pi, List<LogicOperator> Operators)
        {
            this.Pi = new State();
            this.Pi.Fluents.AddRange(Pi.Where(a => a != null).ToList());
            this.Pi.Operators.AddRange(Operators.Where(a => a != null).ToList());
        }
    }

    public abstract class ConditionActionByActorStatement : ConditionStatement
    {
        public Action Action { get; set; }

        public Actor Actor { get; set; }

        public ConditionActionByActorStatement(Action Action, Actor Actor, List<Fluent> PiFluents, List<LogicOperator> Operators) : base(PiFluents, Operators)
        {
            this.Action = Action;
            this.Actor = Actor;
        }
    }

    public abstract class StatementAfterActionByUser : Statement
    {
        public List<(Action action, Actor actor)> ActionsByActors { get; set; }

        public StatementAfterActionByUser(List<(Action action, Actor actor)> actionsByActors)
        {
            this.ActionsByActors = actionsByActors == null ? new List<(Action action, Actor actor)>() :
                    actionsByActors.Where(a => a.action != null && a.actor != null).ToList();
        }

    }

    //Same as FluentAfterActionbyActor but actors and action empty
    public class InitiallyFluent : FluentAfterActionbyActor
    {
        public InitiallyFluent(List<Fluent> Alpha, List<LogicOperator> LogicOperators) : base(Alpha, LogicOperators, null)
        { }

        public override string ToString()
        {
            return $"initially {Alpha.ToString()}";
        }

    }

    public class FluentAfterActionbyActor : StatementAfterActionByUser
    {
        public State Alpha { get; set; }

        public FluentAfterActionbyActor(List<Fluent> Alpha, List<LogicOperator> Operators, List<(Action action, Actor actor)> actionsByActors) : base(actionsByActors) 
        {
            this.Alpha = new State();
            this.Alpha.Fluents.AddRange(Alpha);
            this.Alpha.Operators.AddRange(Operators);
        }

        public override string ToString()
        {
            var str = $"{Alpha.ToString()} after";
            for (var i = 0; i < ActionsByActors.Count; i++)
            {
                var comma = i != 0 ? "," : "";
                str = str + $"{comma} {ActionsByActors[i].action} by {ActionsByActors[i].actor}";
            }
            return str;
        }

    }

    public class FluentTypicallyAfterActionbyActor : StatementAfterActionByUser
    {
        public State Alpha { get; set; }

        public FluentTypicallyAfterActionbyActor(List<Fluent> Alpha, List<LogicOperator> Operators, List<(Action action, Actor actor)> actionsByActors) : base(actionsByActors)
        {
            this.Alpha = new State();
            this.Alpha.Fluents.AddRange(Alpha);
            this.Alpha.Operators.AddRange(Operators);
        }

        public override string ToString()
        {
            var str = $"{Alpha} typically after";
            for (var i = 0; i < ActionsByActors.Count; i++)
            {
                var comma = i != 0 ? "," : "";
                str = str + $"{comma} {ActionsByActors[i].action} by {ActionsByActors[i].actor}";
            }
            return str;
        }

    }

    public class ObservableFluentAfterActionByActor : StatementAfterActionByUser
    {
        public State Alpha { get; set; }

        public ObservableFluentAfterActionByActor(List<Fluent> Alpha, List<LogicOperator> Operators, List<(Action action, Actor actor)> actionsByActors) : base(actionsByActors)
        {
            this.Alpha = new State();
            this.Alpha.Fluents.AddRange(Alpha);
            this.Alpha.Operators.AddRange(Operators);
        }

        public override string ToString()
        {
            var str = $"observable {Alpha.ToString()} after";
            for (var i = 0; i < ActionsByActors.Count; i++)
            {
                var comma = i != 0 ? "," : "";
                str = str + $"{comma} {ActionsByActors[i].action} by {ActionsByActors[i].actor}";
            }
            return str;
        }
    }

    public class ActionByActorCausesAlphaIfFluents : ConditionActionByActorStatement
    {
        public State Alpha { get; set; }


        public ActionByActorCausesAlphaIfFluents(List<Fluent> Alpha, List<LogicOperator> Operators, Action Action, Actor Actor, List<Fluent> Pi, List<LogicOperator> OperatorsPi) : base(Action ,Actor, Pi, OperatorsPi)
        {
            this.Alpha = new State();
            this.Alpha.Fluents.AddRange(Alpha);
            this.Alpha.Operators.AddRange(Operators);
        }

        public override string ToString()
        {
            var conditionStr = string.IsNullOrEmpty(Pi.ToString()?.Trim()) ? string.Empty : $"if { Pi.ToString()}";
            return $"{Action} by {Actor} casues {Alpha.ToString()} {conditionStr}";
        }
    }

    public class ActionByActorReleasesFluent1IfFluents : ConditionActionByActorStatement
    {
        public Fluent F { get; set; }

        public ActionByActorReleasesFluent1IfFluents(Fluent F, Action Action, Actor Actor, List<Fluent> Pi, List<LogicOperator> OperatorsPi) : base(Action ,Actor, Pi, OperatorsPi)
        {
            this.F = F;
        }

        public override string ToString()
        {
            var conditionStr = string.IsNullOrEmpty(Pi.ToString()?.Trim()) ? string.Empty : $"if { Pi.ToString()}";
            return $"{Action} by {Actor} releases {F} {conditionStr}";
        }
    }

    public class ActionByActorTypicallyCausesAlphaIfFluents : ConditionActionByActorStatement
    {
        public State Alpha { get; set; }

        public ActionByActorTypicallyCausesAlphaIfFluents(List<Fluent> Alpha, List<LogicOperator> Operators, Action Action, Actor Actor, List<Fluent> Pi, List<LogicOperator> OperatorsPi) : base(Action, Actor, Pi, OperatorsPi)
        {
            this.Alpha = new State();
            this.Alpha.Fluents.AddRange(Alpha);
            this.Alpha.Operators.AddRange(Operators);
        }

        public override string ToString()
        {
            var conditionStr = string.IsNullOrEmpty(Pi.ToString()?.Trim()) ? string.Empty : $"if { Pi.ToString()}";
            return $"{Action} by {Actor} typically casues {Alpha} {conditionStr}";
        }
    }

    public class ActionByActorTypicallyReleasesFluent1IfFluents : ConditionActionByActorStatement
    {
        public Fluent F { get; set; }

        public ActionByActorTypicallyReleasesFluent1IfFluents(Fluent F, Action Action, Actor Actor, List<Fluent> Pi, List<LogicOperator> OperatorsPi) : base(Action, Actor, Pi, OperatorsPi)
        {
            this.F = F;
        }

        public override string ToString()
        {
            var conditionStr = string.IsNullOrEmpty(Pi.ToString()?.Trim()) ? string.Empty : $"if { Pi.ToString()}";
            return $"{Action} by {Actor} typically releases {F} {conditionStr}";
        }
    }

    public class ImpossibleActionByActorIfFluents : ConditionActionByActorStatement
    {
        public ImpossibleActionByActorIfFluents(Action Action, Actor Actor, List<Fluent> Pi, List<LogicOperator> OperatorsPi) : base(Action, Actor, Pi, OperatorsPi) { }

        public override string ToString()
        {
            var conditionStr = string.IsNullOrEmpty(Pi.ToString()?.Trim()) ? string.Empty : $"if { Pi.ToString()}";
            return $"impossible {Action} by {Actor} {conditionStr}";
        }
    }

    public class AlwaysPi : ConditionStatement
    {
        public AlwaysPi(List<Fluent> Pi, List<LogicOperator> OperatorsPi) : base(Pi, OperatorsPi) { }
        public override string ToString()
        {
            if (Pi == null || Pi.Fluents.Count == 0) return string.Empty;

            return Pi.ToString();
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
