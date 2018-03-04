using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoVairablesWithoutUsingThirdVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=5,b=10;
            a=b+a;
            b=a-b;
            a=a-b;
            Console.WriteLine ("a= %d  b=  %d",a,b);
        }
    }
}
