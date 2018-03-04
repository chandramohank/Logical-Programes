using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Write prime numbers between 0 and 100.
            //
            Console.WriteLine("--- Primes between 0 and 100 ---");
            for (int i = 0; i < 100; i++)
            {
                bool prime = PrimeTool.IsPrime(i);
                if (prime)
                {
                    Console.Write("Prime: ");
                    Console.WriteLine(i);
                }
            }
            //
            // Write prime numbers between 10000 and 10100
            //
            Console.WriteLine("--- Primes between 10000 and 10100 ---");
            for (int i = 10000; i < 10200; i++)
            {
                if (PrimeTool.IsPrime(i))
                {
                    Console.Write("Prime: ");
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

            //Write 0dd Numbers
        }
    }
    public static class PrimeTool
    {
        public static bool IsPrime(int num)
        {

            if (num==1)
            {
                return false;
            }
            else if (num==2)
            {
                return true;
            }

            for (int i = 2; i <= Math.Floor(Math.Sqrt(num)); i++)
			{
                if (num%i==0)
                {
                    return false;
                }
			}
            return true;
        }
    }
}
