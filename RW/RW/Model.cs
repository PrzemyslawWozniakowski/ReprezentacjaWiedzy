using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RW
{
    public class Model
    {
        public class State
        {
            private bool[] fluents;
            public List<int>[,] certainEffects; //by agents x actions
            public State(bool[] fluents)
            {
                this.fluents = new bool[fluents.Length];
                for(int i = 0; i < fluents.Length; i++) this.fluents[i] = fluents[i];
            }
            
            public bool SatisfiesCondition(int[] conditions)
            {
                for(int i=0;i<fluents.Length;i++)
                {
                    if (conditions[i] == -1) continue;
                    if (conditions[i] == 1 && fluents[i] == false) return false;
                    if (conditions[i] == 0 && fluents[i] == true) return false;
                }
                return true;
            }

            public bool LoadStatement(Statement_Causes s)
            {
                if (!SatisfiesCondition(s.condition)) return false;
                // tutaj te resy liczymy
                return true;
            }

            //public bool LoadStatement()

        }
    
        private string[] fluent;
        private State[] state;
        private string[] agent;
        private string[] action;


        public Model(List<string> fluent, List<string> agent, List<string> action)
        {
            int stateCount = (int)Math.Pow(2, fluent.Count);
            bool[] fluentValues = new bool[fluent.Count];
            int t = 0;
            state = new State[stateCount];
            for(int i = 0; i < stateCount; i++)
            {
                for(int j=0; j < fluent.Count; j++)
                {
                    t = stateCount;
                    t %= ((int)Math.Pow(2, j+1));
                    t /= ((int)Math.Pow(2, j));
                    fluentValues[i] = t==1 ? true : false;
                }
                state[i] = new State(fluentValues);
            }
            this.fluent = new string[fluent.Count];
            this.agent = new string[agent.Count];
            this.action = new string[action.Count];
            for (int i = 0; i < agent.Count; i++) this.agent[i] = agent[i];
            for (int i = 0; i < action.Count; i++) this.action[i] = action[i];
            for (int i = 0; i < fluent.Count; i++) this.fluent[i] = fluent[i];
        }

    }
}
