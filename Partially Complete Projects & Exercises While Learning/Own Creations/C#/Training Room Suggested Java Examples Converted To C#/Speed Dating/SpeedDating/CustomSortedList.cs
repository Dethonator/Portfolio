using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedDating
{
    public class CustomSortedList<T1, T2> : List<Tuple<T1, T2>> where T1 : IComparable
    {
        public void Add(T1 item, T2 item2)
        {
            Add(new Tuple<T1, T2>(item, item2));
        }

        public new void Sort()
        {
            Comparison<Tuple<T1, T2>> c = (a, b) => b.Item1.CompareTo(a.Item1);
            base.Sort(c);
        }

    }
}
