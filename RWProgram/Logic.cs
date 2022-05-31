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
            new RWLogic.Test().Run();
            return true;
        }
    }
}
