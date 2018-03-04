using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSecondLargestInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arry = { 5,8,9,10};
            int largest=0;
            int second=0;
            foreach (var item in arry)
            {
                if (item>largest)
                {
                    second = largest;
                    largest = item;
                }
                else if (item>second)
                {
                    second = item;
                }
            }
            Console.WriteLine("First Largest:" + largest);
            Console.WriteLine("Seond Largest:" + second);
            Console.ReadLine();

            //Using Linque

          var secondNumber=  arry.OrderByDescending(c => c).Skip(1).Take(1);
        }
    }
}
