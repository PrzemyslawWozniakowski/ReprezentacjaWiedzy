using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RWProgram.Classes;
using Action = RWProgram.Classes.Action;

namespace RWProgram
{
    public static class Tests
    {
        public static Logic Test1
        {
            get
            {
                var loaded = new Fluent { Name = "loaded", Index = 0 };
                var notLoaded = new NegatedFluent { Name = "loaded", Original = loaded };
                var alive = new Fluent { Name = "alive", Index = 1 };
                var notAlive = new NegatedFluent { Name = "alive", Original = alive };
                var bill = new Actor { Name = "Bill", Index = 0 };
                var jim = new Actor { Name = "Jim", Index = 1 };
                var load = new Action { Name = "LOAD", Index = 0 };
                var shoot = new Action { Name = "SHOOT", Index = 1 };

                var anyone = new Actor { Name = "Anyone", Index = 1000 };
                var empty = new Actor { Name = "ɛ", Index = 1001 };
                var anything = new Action { Name = "Anything", Index = 1000 };

                return new Logic
                {
                    Fluents = new List<Fluent> { loaded, notLoaded, alive, notAlive },
                    Actors = new List<Actor> { bill, jim, anyone, empty },
                    Actions = new List<Action> { load, shoot, anything },
                    Statements = new List<Statement> { 
                        new InitiallyFluent(new List<Fluent> { notLoaded }, new List<LogicOperator>()),
                        new InitiallyFluent(new List<Fluent> { alive }, new List<LogicOperator>()),
                        new ActionByActorCausesAlphaIfFluents(new List<Fluent>{ loaded }, new List<LogicOperator>(), load, bill, new List<Fluent>(), new List<LogicOperator>()),
                        new ActionByActorCausesAlphaIfFluents(new List<Fluent>{ notLoaded }, new List<LogicOperator>(), shoot, bill, new List<Fluent>(), new List<LogicOperator>()),
                        new ActionByActorCausesAlphaIfFluents(new List<Fluent>{ notAlive }, new List<LogicOperator>(), shoot, bill, new List<Fluent> { loaded }, new List<LogicOperator>()),
                    }
                };
            }
        }

        public static Logic Test2
        {
            get
            {
                var loaded = new Fluent { Name = "loaded", Index = 0 };
                var notLoaded = new NegatedFluent { Name = "loaded", Original = loaded };
                var alive = new Fluent { Name = "alive", Index = 1 };
                var notAlive = new NegatedFluent { Name = "alive", Original = alive };
                var bill = new Actor { Name = "Bill", Index = 0 };
                var jim = new Actor { Name = "Jim", Index = 1 };
                var load = new Action { Name = "LOAD", Index = 0 };
                var shoot = new Action { Name = "SHOOT", Index = 1 };

                var anyone = new Actor { Name = "Anyone", Index = 1000 };
                var empty = new Actor { Name = "ɛ", Index = 1001 };
                var anything = new Action { Name = "Anything", Index = 1000 };

                return new Logic
                {
                    Fluents = new List<Fluent> { loaded, notLoaded, alive, notAlive },
                    Actors = new List<Actor> { bill, jim, anyone, empty },
                    Actions = new List<Action> { load, shoot, anything },
                    Statements = new List<Statement> {
                        new InitiallyFluent(new List<Fluent> { alive }, new List<LogicOperator>()),
                        new ActionByActorCausesAlphaIfFluents(new List<Fluent>{ loaded }, new List<LogicOperator>(), load, bill, new List<Fluent>(), new List<LogicOperator>()),
                        new ActionByActorCausesAlphaIfFluents(new List<Fluent>{ notLoaded }, new List<LogicOperator>(), shoot, bill, new List<Fluent>(), new List<LogicOperator>()),
                        new ActionByActorCausesAlphaIfFluents(new List<Fluent>{ notAlive }, new List<LogicOperator>(), shoot, bill, new List<Fluent> { loaded }, new List<LogicOperator>()),
                        new FluentAfterActionbyActor(new List<Fluent> {notAlive}, new List<LogicOperator>(), new List<(Classes.Action action, Actor actor)> { (shoot, bill) })
                    }
                };
            }
        }

        public static Logic Test3
        {
            get
            {
                var loaded = new Fluent { Name = "loaded", Index = 0 };
                var notLoaded = new NegatedFluent { Name = "loaded", Original = loaded };
                var alive = new Fluent { Name = "alive", Index = 1 };
                var notAlive = new NegatedFluent { Name = "alive", Original = alive };
                var bill = new Actor { Name = "Bill", Index = 0 };
                var load = new Action { Name = "LOAD", Index = 0 };
                var shoot = new Action { Name = "SHOOT", Index = 1 };
                var spin = new Action { Name = "SPIN", Index = 2 };

                var anyone = new Actor { Name = "Anyone", Index = 1000 };
                var empty = new Actor { Name = "ɛ", Index = 1001 };
                var anything = new Action { Name = "Anything", Index = 1000 };
                
                return new Logic
                {
                    Fluents = new List<Fluent> { loaded, notLoaded, alive, notAlive },
                    Actors = new List<Actor> { bill, anyone, empty },
                    Actions = new List<Action> { load, shoot, anything },
                    Statements = new List<Statement> {
                        new InitiallyFluent(new List<Fluent> { notLoaded, alive }, new List<LogicOperator> { new And() }),
                        new ActionByActorCausesAlphaIfFluents(new List<Fluent>{ loaded }, new List<LogicOperator>(), load, bill, new List<Fluent>(), new List<LogicOperator>()),
                        new ActionByActorCausesAlphaIfFluents(new List<Fluent>{ notLoaded }, new List<LogicOperator>(), shoot, bill, new List<Fluent>(), new List<LogicOperator>()),
                        new ActionByActorCausesAlphaIfFluents(new List<Fluent>{ notAlive }, new List<LogicOperator>(), shoot, bill, new List<Fluent> { loaded }, new List<LogicOperator>()),
                        new ActionByActorReleasesFluent1IfFluents(loaded, spin, bill, new List<Fluent> { loaded }, new List<LogicOperator>() ),
                    }
                };
            }
        }

        public static Logic Test4
        {
            get
            {
                var open = new Fluent { Name = "open", Index = 0 };
                var notOpen = new NegatedFluent { Name = "open", Original = open };
                var hasCard = new Fluent { Name = "hasCard", Index = 1 };
                var notHasCard = new NegatedFluent { Name = "hasCard", Original = hasCard };
                var bill = new Actor { Name = "Bill", Index = 0 };
                var insertCard = new Action { Name = "INSERT_CARD", Index = 0 };

                var anyone = new Actor { Name = "Anyone", Index = 1000 };
                var empty = new Actor { Name = "ɛ", Index = 1001 };
                var anything = new Action { Name = "Anything", Index = 1000 };

                return new Logic
                {
                    Fluents = new List<Fluent> { open, notOpen, hasCard, notHasCard },
                    Actors = new List<Actor> { bill, anyone, empty },
                    Actions = new List<Action> { insertCard, anything },
                    Statements = new List<Statement> {
                        new InitiallyFluent(new List<Fluent> { notOpen }, new List<LogicOperator>()),
                        new ActionByActorCausesAlphaIfFluents(new List<Fluent>{ open }, new List<LogicOperator>(), insertCard, bill, new List<Fluent>(), new List<LogicOperator>()),
                        new ImpossibleActionByActorIfFluents(insertCard, bill, new List<Fluent> { hasCard }, new List<LogicOperator>())
                    }
                };
            }
        }

        public static Logic Test5
        {
            get
            {
                var loaded = new Fluent { Name = "loaded", Index = 0 };
                var notLoaded = new NegatedFluent { Name = "loaded", Original = loaded };
                var alive = new Fluent { Name = "alive", Index = 1 };
                var notAlive = new NegatedFluent { Name = "alive", Original = alive };
                var bill = new Actor { Name = "Bill", Index = 0 };
                var jim = new Actor { Name = "Jim", Index = 1 };
                var load = new Action { Name = "LOAD", Index = 0 };
                var shoot = new Action { Name = "SHOOT", Index = 1 };

                var anyone = new Actor { Name = "Anyone", Index = 1000 };
                var empty = new Actor { Name = "ɛ", Index = 1001 };
                var anything = new Action { Name = "Anything", Index = 1000 };

                return new Logic
                {
                    Fluents = new List<Fluent> { loaded, notLoaded, alive, notAlive },
                    Actors = new List<Actor> { bill, jim, anyone, empty },
                    Actions = new List<Action> { load, shoot, anything },
                    Statements = new List<Statement> {
                        new InitiallyFluent(new List<Fluent> { notLoaded }, new List<LogicOperator>()),
                        new InitiallyFluent(new List<Fluent> { alive }, new List<LogicOperator>()),
                        new ActionByActorCausesAlphaIfFluents(new List<Fluent>{ loaded }, new List<LogicOperator>(), load, bill, new List<Fluent>(), new List<LogicOperator>()),
                        new ActionByActorCausesAlphaIfFluents(new List<Fluent>{ notLoaded }, new List<LogicOperator>(), shoot, bill, new List<Fluent>(), new List<LogicOperator>()),
                        new ActionByActorTypicallyCausesAlphaIfFluents(new List<Fluent>{ notAlive }, new List<LogicOperator>(), shoot, bill, new List<Fluent> { loaded }, new List<LogicOperator>()),
                    }
                };
            }
        }
    }
}
