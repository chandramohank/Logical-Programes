using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForPalindram
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(isPalindram(123)?"is a palindram":"not a palindram");
           Console.ReadLine();
        }

        public static bool isPalindram(int number)
        {
            var original = number;
            var rev=0;
            while (number>0)
            {
                var reminder = number % 10;
                rev = rev * 10 + reminder;
                number = number / 10;
            }

            if (original==rev)
            {
                return true;
            }
            return false;
        }
    }
}
