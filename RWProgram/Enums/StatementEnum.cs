using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWProgram.Enums
{
    public enum StatementEnum
    {
        InitiallyFluent,
        FluentAfterActionbyActor,
        ObservableFluentAfterActionByActor,
        ActionByActorCausesAlphaIfFluent,
        ActionByActorReleasesFluent1IfFluent2,
        ActionByActorTypicallyCausesAlphaIfFluent,
        ActionByActorTypicallyReleasesFluent1IfFluent2,
        ImpossibleActionByActorIfFluent,
        AlwaysPi,
        NoninertialFluent
    }
}
