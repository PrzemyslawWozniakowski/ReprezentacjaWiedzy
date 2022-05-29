using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RW
{
    public class Model
    {
        public string[] fluent { get; } // fluenty z nazwami
        public bool[] noninertial { get; private set; } // ktore fluenty sa nieinercjalne
        public State[] state { get; private set; } // tablica wszystkich mozliwych stanow
        public List<State> initial { get; private set; } // lista stanow poczatkowych
        public string[] agent { get; } // agenci z nazwami
        public string[] action { get; } // akcje z nazwami

        // to sa te dziwne znaczki T i odwrocone T, nie wiem czy to potrzebne do czegokolwiek
        public readonly int[] TRUE;
        public readonly int[] FALSE;

        public class State
        {
            public bool forbidden = false; // czy stan jest niedozwolony (nie spelnia always costam)

            public readonly bool[] fluents; // jak ustawione sa fluenty w danym stanie
            public List<State>[,] possibleEffects; // lista wszystkich możliwych bezpośrednich efektow danej akcji danego agenta w tym stanie
            public List<State>[,] typicalEffects; // lista typowych efektów bezpośrednich
            public List<State>[,] abnormalEffects; // lista efektów nietypowych

            public State(bool[] fluents, int agents, int actions)
            {
                this.fluents = new bool[fluents.Length];
                for (int i = 0; i < fluents.Length; i++) this.fluents[i] = fluents[i];
                possibleEffects = new List<State>[agents, actions];
            }

            public bool SatisfiesCondition(Formula condition) // czy stan spelnia warunek
            {
                return condition.CheckCondition(this);
                //if (conditions[0] == 2) return false;
                //for (int i = 0; i < fluents.Length; i++)
                //{
                //    if (conditions[i] == -1) continue;
                //    if (conditions[i] == 1 && fluents[i] == false) return false;
                //    if (conditions[i] == 0 && fluents[i] == true) return false;
                //}
                //return true;
            }

            public string Print()
            {
                string result = "(";
                for (int i = 0; i < fluents.Length; i++)
                {
                    if (fluents[i]) result += 1 + " ";
                    else result += 0 + " ";
                }
                result += ")\n";
                return result;
            }

        }

        // generujemy zbior wszystkich mozliwych stanow i takie tam
        public Model(List<string> fluent, List<string> agent, List<string> action)
        {
            TRUE = new int[fluent.Count];
            FALSE = new int[fluent.Count];

            initial = new();
            for(int i=0;i<fluent.Count;i++)
            {
                TRUE[i] = -1;
                FALSE[i] = 2;
            }

            int stateCount = (int)Math.Pow(2, fluent.Count);
            bool[] fluentValues = new bool[fluent.Count];
            noninertial = new bool[fluent.Count];
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
                state[i] = new State(fluentValues, agent.Count, action.Count);
            }
            this.fluent = new string[fluent.Count];
            this.agent = new string[agent.Count];
            this.action = new string[action.Count];
            for (int i = 0; i < agent.Count; i++) this.agent[i] = agent[i];
            for (int i = 0; i < action.Count; i++) this.action[i] = action[i];
            for (int i = 0; i < fluent.Count; i++) this.fluent[i] = fluent[i];
        }

        // nastepnie przetwarzanie zdan roznych typow w calu wygenerowania odpowiedniego grafu

        public void SetNoninertial(List<Noninertial> noninertial)
        {
            foreach(Noninertial s in noninertial)
                this.noninertial[s.fluent] = true;
            return;
        }

        public void SetAlways(List<Always> always)
        {
            foreach(State s in state)
            {
                foreach(Always a in always)
                {
                    if(!s.SatisfiesCondition(a.condition))
                        s.forbidden = true;
                }
            }
            return;
        }

        public void SetPossibleEffects(List<Causes> causes, List<Releases> releases)
        {
            foreach(State s in state)
            {
                if (!s.forbidden) for (int i=0; i<agent.Length; i++)
                {
                    for(int j=0;j<action.Length; j++)
                    {
                        s.possibleEffects[i,j] = Res(s, i, j, causes, releases);
                    }
                }
            }
            return;
        }

        public void SetTypicalEffects(List<Causes> causes, List<TypicallyCauses> typicallyCauses, List<Releases> releases, List<TypicallyReleases> typicallyReleases)
        {
            foreach (State s in state)
            {
                if (!s.forbidden) for (int i = 0; i < agent.Length; i++)
                    {
                        for (int j = 0; j < action.Length; j++)
                        {
                            s.typicalEffects[i, j] = TypicalRes(s, i, j, causes, typicallyCauses, releases, typicallyReleases);
                        }
                    }
            }
            return;
        }

        public void SetAbnormalEffects()
        {
            List<State> result = new();
            foreach (State s in state)
            {
                if (!s.forbidden) for (int i = 0; i < agent.Length; i++)
                    {
                        for (int j = 0; j < action.Length; j++)
                        {
                            result.Clear();
                            result.AddRange(s.possibleEffects[i, j]);
                            foreach(State state in result)
                            {
                                if (s.typicalEffects[i, j].Contains(state)) result.Remove(state);
                            }
                            s.abnormalEffects[i, j] = result;
                        }
                    }
            }
            return;
        }

        public void SetInitialStates(List<Initially> initially, List<After> after, List<TypicallyAfter> typicallyAfter, List<ObservableAfter> observableAfter)
        {
            //initially
            foreach(State s in state)
            {
                initial.Add(s);
                foreach(Initially statement in initially)
                {
                    if (!s.SatisfiesCondition(statement.condition)) initial.Remove(s);
                }
            }
            List<State> result = new();

            //after
            foreach(State s in initial)
            {
                result.Add(s);
                bool end = false;
                foreach(After statement in after)
                {
                    if (end) break;
                    Stack<(State state, int i)> DFS = new();
                    (State state, int index) current;
                    DFS.Push((s, 0));
                    while(DFS.Count != 0)
                    {
                        current = DFS.Pop();
                        if(current.index == statement.activity.Count)
                        {
                            if(!current.state.SatisfiesCondition(statement.effect))
                            {
                                result.Remove(s);
                                end = true;
                                break;
                            }
                        }
                        else foreach(State res in current.state.possibleEffects[
                                                statement.activity[current.index].agent,
                                                statement.activity[current.index].action])
                            {
                                DFS.Push((res, current.index + 1));
                            }
                    }

                }
            }
            initial.Clear();
            initial.AddRange(result);
            result.Clear();

            //typically after
            foreach (State s in initial)
            {
                result.Add(s);
                bool end = false;
                foreach (TypicallyAfter statement in typicallyAfter)
                {
                    if (end) break;
                    Stack<(State state, int i)> DFS = new();
                    (State state, int index) current;
                    DFS.Push((s, 0));
                    while (DFS.Count != 0)
                    {
                        current = DFS.Pop();
                        if (current.index == statement.activity.Count)
                        {
                            if (!current.state.SatisfiesCondition(statement.effect))
                            {
                                result.Remove(s);
                                end = true;
                                break;
                            }
                        }
                        else foreach (State res in current.state.possibleEffects[
                                                statement.activity[current.index].agent,
                                                statement.activity[current.index].action])
                            {
                                DFS.Push((res, current.index + 1));
                            }
                    }

                }
            }
            initial.Clear();
            initial.AddRange(result);
            result.Clear();

            //observable
            foreach (State s in initial)
            {
                result.Add(s);
                bool end = false;
                foreach (ObservableAfter statement in observableAfter)
                {
                    if (end) break;
                    Stack<(State state, int i)> DFS = new();
                    (State state, int index) current;
                    DFS.Push((s, 0));
                    while (DFS.Count != 0)
                    {
                        current = DFS.Pop();
                        if (current.index == statement.activity.Count)
                        {
                            if (current.state.SatisfiesCondition(statement.effect))
                            {
                                end = true;
                                break;
                            }
                        }
                        else foreach (State res in current.state.possibleEffects[
                                                statement.activity[current.index].agent, 
                                                statement.activity[current.index].action])
                            {
                                DFS.Push((res, current.index + 1));
                            }
                    }
                    if(!end) result.Remove(s);
                }
            }
            initial.Clear();
            initial.AddRange(result);

            return;
        }

        // tutaj mozna wrzucic metody, ktore przetwarzaja kwerendy, przykladowo:
        /*
        public bool IsAlwaysExecutable(Query_ExecutableAlways query)
        {
            costam costam;
        }

        public bool IsEverAccessible(Query_AccessibleEver query)
        {
            // wydaje mi sie, ze tutaj trzeba wyjsc ze stanow poczatkowych
            // przejsc do kolejnych stanow za pomoca state.CertainEffect[agent, akcja]
            // i costam sprawdzic za pomoca state.SatisfiesCondtion(stan koncowy), ale pewien nie jestem
            costam costam;
        }
        */

        public bool IsAlwaysExecutable(Query_ExecutableAlways query)
        {
            throw new NotImplementedException();
        }

        public bool IsEverExecutable(Query_ExecutableEver query)
        {
            throw new NotImplementedException();
        }

        public bool IsAlwaysAccessible(Query_AccessibleAlways query)
        {
            throw new NotImplementedException();
        }

        public bool IsEverAccessible(Query_AccessibleEver query)
        {
            throw new NotImplementedException();
        }

        public bool IsAlwaysInvolved(Query_InvolvedAlways query)
        {
            throw new NotImplementedException();
        }

        public bool IsEverInvolved(Query_InvolvedEver query)
        {
            throw new NotImplementedException();
        }




        // dalej jest magia, ktora dzieje przy generowaniu grafu

        private List<State> Res0(State s, int agent, int action, List<Causes> causes)
        {
            bool Res0_Condition(State s, int agent, int action, State res, List<Causes> causes)
            {
                foreach (Causes c in causes)
                {
                    if ((c.agent == agent &&
                        c.action == action &&
                        s.SatisfiesCondition(c.condition)) &&
                        !res.SatisfiesCondition(c.effect))
                    {
                        return false;
                    }
                }
                return true;
            }

            List<State> result = new();
            bool[] contains = new bool[state.Length];
            for (int i = 0; i < state.Length; i++)
            {
                if (!state[i].forbidden && Res0_Condition(s, agent, action, state[i], causes))
                {
                    if (!contains[i])
                    {
                        result.Add(state[i]);
                        contains[i] = true;
                    }
                }
            }
            return result;
        }

        private bool[] New(State s, int agent, int action, State res, List<Releases> releases)
        {
            bool[] result = new bool[fluent.Length];
            for(int i=0;i<fluent.Length;i++)
            {
                if (!noninertial[i] && s.fluents[i] != res.fluents[i]) // warunek 1 dla inercjalnych
                    result[i] = true;
                else // warunek 2 z releases
                {
                    foreach(Releases statement in releases)
                    {
                        if(statement.agent == agent &&
                            statement.action == action &&
                            s.SatisfiesCondition(statement.condition) &&
                            !res.SatisfiesCondition(statement.effect))
                        {
                            result[i] = true;
                            break;
                        }
                    }
                }
            }
            return result;
        }

        private bool Subset(bool[] A, bool[] B)
        {
            for(int i=0;i<A.Length;i++)
            {
                if (A[i] && !B[i]) return false;
            }
            return true;
        }

        private List<State> Res(State s, int agent, int action, List<Causes> causes, List<Releases> releases)
        {
            List<State> res0 = Res0(s, agent, action, causes);
            List<bool[]> newSet = new();
            foreach(State res in res0)
            {
                newSet.Add(New(s, agent, action, res, releases));
            }

            bool[] isMinimal = new bool[newSet.Count];
            for(int i=0;i<newSet.Count;i++) isMinimal[i] = true;

            for(int i=0;i<newSet.Count;i++)
            {
                for(int j=i+1;j<newSet.Count;j++)
                {
                    if(Subset(newSet[i], newSet[j])) isMinimal[j] = false;
                }
            }

            List<State> result = new();
            for(int i=0;i<res0.Count;i++)
            {
                if (isMinimal[i]) result.Add(res0[i]);
            }
            return result;
        }

        // Resy dla typowych

        private List<State> TypicalRes0(State s, int agent, int action, List<Causes> causes, List<TypicallyCauses> typically)
        {
            bool Res0_Condition(State s, int agent, int action, State res, List<Causes> causes, List<TypicallyCauses> typically)
            {
                List<CausesOrTypicallyCauses> statements = new();
                statements.AddRange(causes);
                statements.AddRange(typically);
                foreach (CausesOrTypicallyCauses c in statements)
                {
                    if ((c.agent == agent &&
                        c.action == action &&
                        s.SatisfiesCondition(c.condition)) &&
                        !res.SatisfiesCondition(c.effect))
                    {
                        return false;
                    }
                }
                return true;
            }

            List<State> result = new();
            bool[] contains = new bool[state.Length];
            for (int i = 0; i < state.Length; i++)
            {
                if (!state[i].forbidden && Res0_Condition(s, agent, action, state[i], causes, typically))
                {
                    if (!contains[i])
                    {
                        result.Add(state[i]);
                        contains[i] = true;
                    }
                }
            }
            return result;
        }

        private bool[] TypicalNew(State s, int agent, int action, State res, List<Releases> releases, List<TypicallyReleases> typically)
        {
            List<ReleasesOrTypicallyReleases> statements = new();
            statements.AddRange(releases);
            statements.AddRange(typically);

            bool[] result = new bool[fluent.Length];
            for (int i = 0; i < fluent.Length; i++)
            {
                if (!noninertial[i] && s.fluents[i] != res.fluents[i]) // warunek 1 dla inercjalnych
                    result[i] = true;
                else // warunek 2 z releases
                {
                    foreach(ReleasesOrTypicallyReleases statement in statements)
                    {
                        if (statement.agent == agent &&
                            statement.action == action &&
                            s.SatisfiesCondition(statement.condition) &&
                            !res.SatisfiesCondition(statement.effect))
                        {
                            result[i] = true;
                            break;
                        }
                    }
                }
            }
            return result;
        }

        private List<State> TypicalRes(State s, int agent, int action, List<Causes> causes, List<TypicallyCauses> typicallyCauses, List<Releases> releases, List<TypicallyReleases> typicallyReleases)
        {
            List<State> res0 = TypicalRes0(s, agent, action, causes, typicallyCauses);
            List<bool[]> newSet = new();
            foreach (State res in res0)
            {
                newSet.Add(TypicalNew(s, agent, action, res, releases, typicallyReleases));
            }

            bool[] isMinimal = new bool[newSet.Count];
            for (int i = 0; i < newSet.Count; i++) isMinimal[i] = true;

            for (int i = 0; i < newSet.Count; i++)
            {
                for (int j = i + 1; j < newSet.Count; j++)
                {
                    if (Subset(newSet[i], newSet[j])) isMinimal[j] = false;
                }
            }

            List<State> result = new();
            for (int i = 0; i < res0.Count; i++)
            {
                if (isMinimal[i]) result.Add(res0[i]);
            }
            return result;
        }
    }
}
