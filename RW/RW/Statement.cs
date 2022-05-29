using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RW
{
    public interface Always
    {
        Formula condition { get; }
    }

    public interface Noninertial
    {
        int fluent { get; }
    }

    public interface CausesOrTypicallyCauses
    {
        int agent { get; } //id agenta
        int action { get; } //id akcji
        Formula condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
        Formula effect { get; } //tablica wartosci fluentow w efekcie akcji: 1 = prawda, 0 = falsz, -1 = bez znaczenia
    }

    public interface Causes : CausesOrTypicallyCauses
    {
        int agent { get; } //id agenta
        int action { get; } //id akcji
        Formula condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
        Formula effect { get; } //tablica wartosci fluentow w efekcie akcji: 1 = prawda, 0 = falsz, -1 = bez znaczenia
    }

    public interface TypicallyCauses : CausesOrTypicallyCauses
    {
        int agent { get; } //id agenta
        int action { get; } //id akcji
        Formula condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
        Formula effect { get; } //tablica wartosci fluentow w efekcie akcji: 1 = prawda, 0 = falsz, -1 = bez znaczenia
    }

    public interface ReleasesOrTypicallyReleases
    {
        int agent { get; } //id agenta
        int action { get; } //id akcji
        Formula condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
        Formula effect { get; } //tablica wartosci fluentow w efekcie akcji: 1 = prawda, 0 = falsz, -1 = bez znaczenia
    }

    public interface Releases : ReleasesOrTypicallyReleases
    {
        int agent { get; } //id agenta
        int action { get; } //id akcji
        Formula condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
        Formula effect { get; } //tablica wartosci fluentow w efekcie akcji: 1 = prawda, 0 = falsz, -1 = bez znaczenia
    }

    public interface TypicallyReleases : ReleasesOrTypicallyReleases
    {
        int agent { get; } //id agenta
        int action { get; } //id akcji
        Formula condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
        Formula effect { get; } //tablica wartosci fluentow w efekcie akcji: 1 = prawda, 0 = falsz, -1 = bez znaczenia
    }

    public interface Initially
    {
        Formula condition { get; }
    }

    public interface After
    {
        List<(int agent, int action)> activity { get; }
        Formula effect { get; }
    }

    public interface TypicallyAfter
    {
        List<(int agent, int action)> activity { get; }
        Formula effect { get; }
    }

    public interface ObservableAfter
    {
        List<(int agent, int action)> activity { get; }
        Formula effect { get; }
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
