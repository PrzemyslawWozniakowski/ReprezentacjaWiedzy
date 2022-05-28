using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RW
{
    public interface Always
    {
        int[] condition { get; }
    }

    public interface Noninertial
    {
        int fluent { get; }
    }

    public interface CausesOrTypicallyCauses
    {
        int agent { get; } //id agenta
        int action { get; } //id akcji
        int[] condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
        int[] effect { get; } //tablica wartosci fluentow w efekcie akcji: 1 = prawda, 0 = falsz, -1 = bez znaczenia
    }

    public interface Causes : CausesOrTypicallyCauses
    {
        int agent { get; } //id agenta
        int action { get; } //id akcji
        int[] condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
        int[] effect { get; } //tablica wartosci fluentow w efekcie akcji: 1 = prawda, 0 = falsz, -1 = bez znaczenia
    }

    public interface TypicallyCauses : CausesOrTypicallyCauses
    {
        int agent { get; } //id agenta
        int action { get; } //id akcji
        int[] condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
        int[] effect { get; } //tablica wartosci fluentow w efekcie akcji: 1 = prawda, 0 = falsz, -1 = bez znaczenia
    }

    public interface ReleasesOrTypicallyReleases
    {
        int agent { get; } //id agenta
        int action { get; } //id akcji
        int[] condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
        int[] effect { get; } //tablica wartosci fluentow w efekcie akcji: 1 = prawda, 0 = falsz, -1 = bez znaczenia
    }

    public interface Releases : ReleasesOrTypicallyReleases
    {
        int agent { get; } //id agenta
        int action { get; } //id akcji
        int[] condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
        int[] effect { get; } //tablica wartosci fluentow w efekcie akcji: 1 = prawda, 0 = falsz, -1 = bez znaczenia
    }

    public interface TypicallyReleases : ReleasesOrTypicallyReleases
    {
        int agent { get; } //id agenta
        int action { get; } //id akcji
        int[] condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
        int[] effect { get; } //tablica wartosci fluentow w efekcie akcji: 1 = prawda, 0 = falsz, -1 = bez znaczenia
    }

    public interface Initially
    {
        int[] condition { get; }
    }

    public interface After
    {
        List<(int agent, int action)> activity { get; }
        int[] effect { get; }
    }

    public interface TypicallyAfter
    {
        List<(int agent, int action)> activity { get; }
        int[] effect { get; }
    }

    public interface ObservableAfter
    {
        List<(int agent, int action)> activity { get; }
        int[] effect { get; }
    }

    // dalej syntaktyka kwerend

    // public interface Query_ExecutableAlways
    // public interface Query_ExecutableEver
    // public interface Query_AccessibleAlways
    // public interface Query_AccessibleEver
    // public interface Query_InvolvedAlways
    // public interface Query_InvolvedEver
}
