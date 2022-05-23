using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RW
{
    public interface Statement_Causes
    {
        int agent { get; } //id agenta
        int action { get; } //id akcji
        int[] condition { get; } //tablica wartosci fluentow w warunku: 1 = prawda, 0 = falsz, -1 = bez znaczenia
        int[] effect { get; } //tablica wartosci fluentow w efekcie akcji: 1 = prawda, 0 = falsz, -1 = bez znaczenia
    }
}
