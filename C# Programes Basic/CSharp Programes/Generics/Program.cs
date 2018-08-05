using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Gemnerictest.sum<int, int>(1, 1);
        }
    }

    class Gemnerictest
    {

        public static void sum<t1, t2>(t1 x, t2 y)
        {
            var test = x ;
        }
    }
}
