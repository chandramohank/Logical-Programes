using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibnaocii
{
    class Program
    {
        public static void Approach1(int number)
        {
            int a = 0, b = 1, c = 0,counter=0;

            while (counter<number)
            {
                if (c > number)
                {
                    break;
                }
                if (c == 0)
                {
                    counter++;
                    Console.WriteLine(c);
                    if (number == c) break;

                }
                if (c == 1)
                {
                    counter++;
                    Console.WriteLine(c);
                    if (number == c) break;
                }

                c = a + b;
                a = b;
                b = c;
                counter++;
                Console.WriteLine(c);
            }

            Console.ReadLine();
        }

        public static void Fibonacci(int a, int b, int counter, int number)
        {
            Console.WriteLine(a);
            if (counter < number) Fibonacci(b, a + b, counter + 1, number);
        }
        static void Main(string[] args)
        {
            int number = 5;
            Approach1(number);
            Console.WriteLine("Please enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            Fibonacci(0, 1, 1, num);
            Console.ReadLine();
        }
    }
}
