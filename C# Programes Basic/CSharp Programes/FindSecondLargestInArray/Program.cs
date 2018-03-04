using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSecondLargestInArray
{
    class Program
    {

        public static int SecondLargest(int[] arr)
        {
            int Largset = 0;
            int secondLargest = 0;
            foreach (var item in arr)
            {
                if (item>Largset)
                {
                    secondLargest = Largset;
                    Largset = item;
                }
                else if (item > secondLargest)
                {
                    secondLargest = item;
                }
            }

            return secondLargest;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1,5,8,9,7};
            int num = SecondLargest(arr);
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
