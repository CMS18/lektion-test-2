using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lektion_test_2
{
    class kurs
    {
        public string Namn { get; set; }
        public int Poang { get; set; }
        public string StartDatum { get; set; }
        public string SlutDatum { get; set; }

        public double BeraknaAntalKursDagar(DateTime a, DateTime b)
        {
            var Diff = b.Date - a.Date;
            double AntalDagar = Diff.TotalDays;
            return AntalDagar + 1;
        }

        public double PoangPerKursDag(int poang, DateTime a, DateTime b)
        {
            double dagar = BeraknaAntalKursDagar(a, b);
            double poangPerDag = poang / dagar;
            return poangPerDag;
        }
    }
}
