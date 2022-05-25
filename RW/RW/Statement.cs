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

    public interface Causes
    {
        int agent { get; } //id agenta
        int action { get; } //id akcji
        int[] condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
        int[] effect { get; } //tablica wartosci fluentow w efekcie akcji: 1 = prawda, 0 = falsz, -1 = bez znaczenia
    }

    public interface TypicallyCauses
    {
        int agent { get; } //id agenta
        int action { get; } //id akcji
        int[] condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
        int[] effect { get; } //tablica wartosci fluentow w efekcie akcji: 1 = prawda, 0 = falsz, -1 = bez znaczenia
    }

    public interface Releases
    {
        int agent { get; } //id agenta
        int action { get; } //id akcji
        int[] condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
        int[] effect { get; } //tablica wartosci fluentow w efekcie akcji: 1 = prawda, 0 = falsz, -1 = bez znaczenia
    }

    public interface TypicallyReleases
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
    // public interface Query_
}
