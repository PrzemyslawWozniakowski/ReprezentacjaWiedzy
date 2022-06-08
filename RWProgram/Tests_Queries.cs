using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RWProgram.Classes;
using Action = RWProgram.Classes.Action;

namespace RWProgram
{
    public static class Tests_Queries
    {
        public static AlwaysAccesibleYFromPi Test1a
        {
            get
            {
                return new AlwaysAccesibleYFromPi
                {
                    Gamma = new State
                    {
                        Fluents = new List<Fluent>
                        {
                            new NegatedFluent { Name = "alive", Original = new Fluent { Name = "alive", Index = 1 } }
                        },
                        Operators = new List<LogicOperator>
                        {
                        }
                    },
                    Pi = new State
                    {
                        Fluents = new List<Fluent>
                        {
                            new Fluent { Name = "alive", Index = 1 },
                            new NegatedFluent { Name = "loaded", Original = new Fluent { Name = "loaded", Index = 0 } }
                        },
                        Operators = new List<LogicOperator>
                        {
                            new And()
                        }
                    }
                };
            }
        }

        public static AlwaysWInvolved Test1b
        {
            get
            {
                return new AlwaysWInvolved
                {
                    W = new Actor { Name = "Jim", Index = 1 }
                };
            }
        }

        public static EverWInvolved Test1c
        {
            get
            {
                return new EverWInvolved
                {
                    W = new Actor { Name = "Bill", Index = 0 }
                };
            }
        }

        public static EverAccesibleYFromPi Test2a
        {
            get
            {
                return new EverAccesibleYFromPi
                {
                    Gamma = new State
                    {
                        Fluents = new List<Fluent>
                        {
                            new NegatedFluent { Name = "alive", Original = new Fluent { Name = "alive", Index = 1 } }
                        },
                        Operators = new List<LogicOperator>
                        {

                        }
                    },
                    Pi = new State
                    {
                        Fluents = new List<Fluent>
                        {
                            new Fluent { Name = "alive", Index = 1 }
                        },
                        Operators = new List<LogicOperator>
                        {

                        }
                    }
                };
            }
        }

        public static AlwaysExecutable Test2b
        {
            get
            {
                return new AlwaysExecutable
                {
                };
            }
        }

        public static EverExecutable Test2c
        {
            get
            {
                return new EverExecutable
                {
                };
            }
        }

        public static AlwaysExecutable Test3a
        {
            get
            {
                return new AlwaysExecutable
                {
                };
            }
        }

        public static AlwaysAccesibleYFromPi Test3b
        {
            get
            {
                return new AlwaysAccesibleYFromPi
                {
                    Gamma = new State
                    {
                        Fluents = new List<Fluent>
                        {
                            new Fluent { Name = "loaded", Index = 0 }
                        },
                        Operators = new List<LogicOperator>
                        {
                        }
                    },
                    Pi = new State
                    {
                        Fluents = new List<Fluent>
                        {
                            new NegatedFluent { Name = "loaded", Original = new Fluent { Name = "loaded", Index = 0 } }
                        },
                        Operators = new List<LogicOperator>
                        {
                        }
                    }
                };
            }
        }

        public static EverExecutable Test3c
        {
            get
            {
                return new EverExecutable
                {
                };
            }
        }

        public static AlwaysWInvolved Test4a
        {
            get
            {
                return new AlwaysWInvolved
                {
                    W = new Actor { Name = "ɛ", Index = 1 }
                };
            }
        }

        public static EverExecutable Test4b
        {
            get
            {
                return new EverExecutable
                {
                };
            }
        }

        public static EverExecutable Test4c
        {
            get
            {
                return new EverExecutable
                {
                };
            }
        }

        public static EverWInvolved Test5a
        {
            get
            {
                return new EverWInvolved
                {
                    W = new Actor { Name = "ɛ", Index = 1 }
                };
            }
        }

        public static AlwaysExecutable Test5b
        {
            get
            {
                return new AlwaysExecutable
                {
                };
            }
        }

        public static AlwaysWInvolved Test5c
        {
            get
            {
                return new AlwaysWInvolved
                {
                    W = new Actor { Name = "ɛ", Index = 1 }
                };
            }
        }
    }
}
