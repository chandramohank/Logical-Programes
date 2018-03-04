using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibnocii_Using_Recursion
{
    class Program
    {
       private static void Fibonacci_Rec_Temp(int a, int b, int counter, int len)
        {
            if (counter <= len)
            {
                Console.Write("{0} ", a);
               Fibonacci_Rec_Temp(b, a + b, counter+1, len);
            }
       }
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int len = 10;
            int number=9;
            Fibonacci_Rec_Temp(0, 1, 1, len);
            Console.ReadLine();
        }
    }
}
