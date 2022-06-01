using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RWProgram.Classes;
using Action = RWProgram.Classes.Action;

namespace RWProgram
{
    public class Logic
    {
        public List<Actor> Actors = new List<Actor>();

        public List<Fluent> Fluents = new List<Fluent>();

        public List<Action> Actions = new List<Action>();

        public List<Statement> Statements = new List<Statement>();

        public List<(Action action, Actor actor)> Program = new List<(Action, Actor)>();

        public bool ExecuteQuery(Query query)
        {
            var fasada = new RWLogic.Fasada(
                fluents: Fluents.Select(f => f.ToString()).ToList(),
                agents: Actors.Where(a => a.Name != "Anyone").Select(a => a.ToString()).ToList(),
                actions: Actions.Where(a => a.Name != "Anything").Select(a => a.ToString()).ToList(),
                noninertial: GetStatements<NoninertialFluent, RWLogic.Noninertial>().ToList(),
                always: GetStatements<AlwaysPi, RWLogic.Always>().ToList(),
                causes: GetStatementsForConditionActionByActor<ActionByActorCausesAlphaIfFluents, RWLogic.Causes>().ToList(),
                typicallyCauses: GetStatementsForConditionActionByActor<ActionByActorTypicallyCausesAlphaIfFluents, RWLogic.TypicallyCauses>().ToList(),
                releases: GetStatementsForConditionActionByActor<ActionByActorReleasesFluent1IfFluents, RWLogic.Releases>().ToList(),
                typicallyReleases: GetStatementsForConditionActionByActor<ActionByActorTypicallyReleasesFluent1IfFluents, RWLogic.TypicallyReleases>().ToList(),
                initially: GetStatements<InitiallyFluent, RWLogic.Initially>().ToList(),
                after: GetStatements<FluentAfterActionbyActor, RWLogic.After>().ToList(),
                typicallyAfter: GetStatements<FluentTypicallyAfterActionbyActor, RWLogic.TypicallyAfter>().ToList(),
                observableAfter: GetStatements<ObservableFluentAfterActionByActor, RWLogic.ObservableAfter>().ToList()
            );
            return true;
        }

        private IEnumerable<T_Logic> GetStatementsForConditionActionByActor<T_Statement, T_Logic>() where T_Statement : ConditionActionByActorStatement where T_Logic : class
        {
            return Statements
                .Where(s => s is T_Statement)
                .SelectMany(s => GetLogicStatementsWithCondition<T_Statement, T_Logic>(s));
        }

        private IEnumerable<T_Logic> GetStatements<T_Statement, T_Logic>() where T_Statement : Statement where T_Logic : class
        {
            return Statements
                .Where(s => s is T_Statement)
                .Select(s => (s as T_Statement).ToLogic() as T_Logic);
        }

        private IEnumerable<T_Logic> GetLogicStatementsWithCondition<T_Statement, T_Logic>(Statement s) where T_Statement : ConditionActionByActorStatement where T_Logic: class
        {
            var statement = s as T_Statement;
            var statements = new List<T_Logic>();
            if (statement.Actor.Name != "Anyone" && statement.Action.Name != "Anything")
            {
                return new List<T_Logic> { statement.ToLogic() as T_Logic};
            }
            if (statement.Actor.Name == "Anyone")
            {
                foreach (var actor in Actors.Where(a => a.Name != "Anyone"))
                {
                    statement.Actor = actor;
                    statements.Add(statement.ToLogic() as T_Logic);
                }
            }
            if (statement.Action.Name == "Anything")
            {
                foreach (var action in Actions.Where(a => a.Name != "Anything"))
                {
                    statement.Action = action;
                    statements.Add(statement.ToLogic() as T_Logic);
                }
            }
            return statements;
        }
    }
}
