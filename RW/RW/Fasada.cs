using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RW
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

        // tutaj bedzie obsluga kwerend
    }
}
