using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungerKiller.Model
{
    class turn
    {
        public string turnurl { get; set; }
        public string turnname { get; set; }

    }
    class DealManager
    {
        public void DealCountAndCountt(int count, int countt)
        {
            List<int> counts = new List<int>();
            int i, s, j = 1;
            for (i = 1; i <= 10; s++)
            {
                s = count & j;
                if (s == j)
                    counts.Add(i);
                else
                    counts.Add(0);
                i++;
                j = 2 * j;
            }
            s = 0; j = 1;
            for (i = 1; i <= 10; s++)
            {
                s = countt & j;
                if (s == j)
                    counts.Add(i);
                else
                    counts.Add(0);
                i++;
                j = 2 * j;
            }
        }
    }
}
