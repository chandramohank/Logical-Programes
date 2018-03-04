using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxRepeatingValue
{
    class Program
    {
        public static int MostRepeatingValue(int[] A)
        {

            var query = (from item in A
                         group item by item into g
                         orderby g.Count() descending
                         select new { Item = g.Key, Count = g.Count() }).First();

            var res = A.GroupBy(a => a).OrderByDescending(c => c.Count()).Select(c => c.Key).First();

             //old fasahion
            var cnt = new Dictionary<int, int>();
            foreach (var item in A)
            {
                if (cnt.ContainsKey(item))
                {
                    cnt[item]++;
                }
                else
                {
                    cnt.Add(item, 1);
                }
            }

            int highestrepeatingumber;
            int repeatingcounter = 0;
            foreach (var item  in cnt)
            {
                if (item.Value>repeatingcounter)
                {
                    repeatingcounter = item.Value;
                    highestrepeatingumber = item.Key;
                }
                else
                {

                }
            }

            return res;
        }
        static void Main(string[] args)
        {
          Console.WriteLine( MostRepeatingValue(new int[] { 10,11,10,12,11,13,10,43,10,10}));
        }
    }
}
