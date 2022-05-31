using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RW
{
    public class Always
    {
        public Formula condition { get; }

        public Always(Formula condition)
        {
            this.condition = condition;
        }
    }

    public class Noninertial
    {
        public int fluent { get; }

        public Noninertial(int fluent)
        {
            this.fluent = fluent;
        }
    }

    public interface CausesOrTypicallyCauses
    {
        int agent { get; } //id agenta
        int action { get; } //id akcji
        Formula condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
        Formula effect { get; } //tablica wartosci fluentow w efekcie akcji: 1 = prawda, 0 = falsz, -1 = bez znaczenia
    }

    public class Causes : CausesOrTypicallyCauses
    {
        public int agent { get; } //id agenta
        public int action { get; } //id akcji
        public Formula condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
        public Formula effect { get; } //tablica wartosci fluentow w efekcie akcji: 1 = prawda, 0 = falsz, -1 = bez znaczenia

        public Causes(int agent, int action, Formula effect, Formula condition)
        {
            this.agent = agent;
            this.action = action;
            this.condition = condition;
            this.effect = effect;
        }

        public Causes(int agent, int action, Formula effect)
        {
            this.agent = agent;
            this.action = action;
            this.condition = new Formula(true);
            this.effect = effect;
        }
    }

    public class TypicallyCauses : CausesOrTypicallyCauses
    {
        public int agent { get; } //id agenta
        public int action { get; } //id akcji
        public Formula condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
        public Formula effect { get; } //tablica wartosci fluentow w efekcie akcji: 1 = prawda, 0 = falsz, -1 = bez znaczenia

        public TypicallyCauses(int agent, int action, Formula effect, Formula condition)
        {
            this.agent = agent;
            this.action = action;
            this.condition = condition;
            this.effect = effect;
        }

        public TypicallyCauses(int agent, int action, Formula effect)
        {
            this.agent = agent;
            this.action = action;
            this.condition = new Formula(true);
            this.effect = effect;
        }
    }

    public interface ReleasesOrTypicallyReleases
    {
        int agent { get; } //id agenta
        int action { get; } //id akcji
        Formula condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
        int fluent { get; } //tablica wartosci fluentow w efekcie akcji: 1 = prawda, 0 = falsz, -1 = bez znaczenia
    }

    public class Releases : ReleasesOrTypicallyReleases
    {
        public int agent { get; } //id agenta
        public int action { get; } //id akcji
        public Formula condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
        public int fluent { get; } //tablica wartosci fluentow w efekcie akcji: 1 = prawda, 0 = falsz, -1 = bez znaczenia

        public Releases(int agent, int action, int fluent, Formula condition)
        {
            this.agent = agent;
            this.action = action;
            this.condition = condition;
            this.fluent = fluent;
        }

        public Releases(int agent, int action, int fluent)
        {
            this.agent = agent;
            this.action = action;
            this.condition = new Formula(true);
            this.fluent = fluent;
        }

    }

    public class TypicallyReleases : ReleasesOrTypicallyReleases
    {
        public int agent { get; } //id agenta
        public int action { get; } //id akcji
        public Formula condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
        public int fluent { get; } //tablica wartosci fluentow w efekcie akcji: 1 = prawda, 0 = falsz, -1 = bez znaczenia

        public TypicallyReleases(int agent, int action, int fluent, Formula condition)
        {
            this.agent = agent;
            this.action = action;
            this.condition = condition;
            this.fluent = fluent;
        }

        public TypicallyReleases(int agent, int action, int fluent)
        {
            this.agent = agent;
            this.action = action;
            this.condition = new Formula(true);
            this.fluent = fluent;
        }

    }

    public class Initially
    {
        public Formula condition { get; }

        public Initially(Formula condition)
        {
            this.condition = condition;
        }
    }

    public class After
    {
        public List<(int agent, int action)> activity { get; }
        public Formula effect { get; }

        public After(List<(int agent, int action)> activity, Formula effect)
        {
            this.activity = activity;
            this.effect = effect;
        }

    }

    public class TypicallyAfter
    {
        public List<(int agent, int action)> activity { get; }
        public Formula effect { get; }

        public TypicallyAfter(List<(int agent, int action)> activity, Formula effect)
        {
            this.activity = activity;
            this.effect = effect;
        }

    }

    public class ObservableAfter
    {
        public List<(int agent, int action)> activity { get; }
        public Formula effect { get; }

        public ObservableAfter(List<(int agent, int action)> activity, Formula effect)
        {
            this.activity = activity;
            this.effect = effect;
        }
    }

    // dalej syntaktyka kwerend

    public interface Query_ExecutableAlways
    {
        List<(int agent, int action)> program { get; } //program dzialan
    }
    
    public interface Query_ExecutableEver
    {
        List<(int agent, int action)> program { get; } //program dzialan
    }

    public interface Query_AccessibleAlways
    {
        List<(int agent, int action)> program { get; } //program dzialan
        int[] pi_condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
        int[] gamma_condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
    }

    public interface Query_AccessibleEver
    {
        List<(int agent, int action)> program { get; } //program dzialan
        int[] pi_condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
        int[] gamma_condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
    }

    public interface Query_InvolvedAlways
    {
        List<(int agent, int action)> program { get; } //program dzialan
        int action { get; } //id akcji
    }

    public interface Query_InvolvedEver
    {
        List<(int agent, int action)> program { get; } //program dzialan
        int action { get; } //id akcji
    }
}
