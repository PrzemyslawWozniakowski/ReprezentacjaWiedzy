using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicExpressionsParser;

namespace RWLogic
{
    public class Fasada
    {
        private Model model;

        public Fasada(
            List<string> fluents,
            List<string> agents,
            List<string> actions,

            List<Noninertial> noninertial,
            List<Always> always,
            List<Causes> causes,
            List<TypicallyCauses> typicallyCauses,
            List<Releases> releases,
            List<TypicallyReleases> typicallyReleases,
            List<Initially> initially,
            List<After> after,
            List<TypicallyAfter> typicallyAfter,
            List<ObservableAfter> observableAfter)
        {
            model = new Model(fluents, agents, actions);
            model.SetNoninertial(noninertial);
            model.SetAlways(always);
            model.SetPossibleEffects(causes, releases);
            model.SetTypicalEffects(causes, typicallyCauses, releases, typicallyReleases);
            model.SetAbnormalEffects();
            model.SetInitialStates(initially, after, typicallyAfter, observableAfter);
        }

        public string test()
        {
            string log = "";
            log += "nazwy fluentow:\n(";
            for (int i = 0; i < model.fluent.Length; i++) log += model.fluent[i] + " ";
            log += ")\n";
            log += "stany poczatkowe to:\n";
            for (int i = 0; i < model.initial.Count; i++) log += model.initial[i].Print();
            log += "efekty akcji:\n";
            for(int i=0;i<model.state.Length;i++)
            {
                log += "\nstan " + model.state[i].Print();
                if (model.state[i].forbidden)
                {
                    log += "jest niezgodny z dziedzina\n";
                    continue;
                }
                /*log += "- mozliwe efekty: \n";
                for(int action=0; action < model.action.Length;action++)
                {
                    for(int agent=0; agent<model.agent.Length;agent++)
                    {
                        if (model.state[i].possibleEffects[agent, action].Count != 0)
                        {
                            log += model.action[action] + " by " + model.agent[agent] + ":\n";
                            foreach(Model.State s in model.state[i].possibleEffects[agent, action]) log += s.Print();
                        }

                    }
                }*/
                log += "- typowe efekty: \n";
                for (int action = 0; action < model.action.Length; action++)
                {
                    for (int agent = 0; agent < model.agent.Length; agent++)
                    {
                        if (model.state[i].typicalEffects[agent, action].Count != 0)
                        {
                            log += model.action[action] + " by " + model.agent[agent] + ":\n";
                            foreach (State s in model.state[i].typicalEffects[agent, action]) log += s.Print();
                        }

                    }
                }
                log += "- nietypowe efekty: \n";
                for (int action = 0; action < model.action.Length; action++)
                {
                    for (int agent = 0; agent < model.agent.Length; agent++)
                    {
                        if (model.state[i].abnormalEffects[agent, action].Count != 0)
                        {
                            log += model.action[action] + " by " + model.agent[agent] + ":\n";
                            foreach (State s in model.state[i].abnormalEffects[agent, action]) log += s.Print();
                        }

                    }
                }
            }
            return log;
        }
        // tutaj bedzie obsluga kwerend
        
        public bool Query(Query_ExecutableAlways query)
        {
            return model.IsAlwaysExecutable(query);
        }

        public bool Query(Query_ExecutableEver query)
        {
            return model.IsEverExecutable(query);
        }

        public bool Query(Query_AccessibleTypically query)
        {
            return model.IsTypicallyAccessible(query);
        }

        public bool Query(Query_AccessibleAlways query)
        {
            return model.IsAlwaysAccessible(query);
        }

        public bool Query(Query_AccessibleEver query)
        {
            return model.IsEverAccessible(query);
        }

        public bool Query(Query_InvolvedAlways query)
        {
            return model.IsAlwaysInvolved(query);
        }

        public bool Query(Query_InvolvedEver query)
        {
            return model.IsEverInvolved(query);
        }
    }
}
