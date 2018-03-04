using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindram
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenNumber = 5452;
            int temp = givenNumber;
            var reversenumber = 0;
            while (givenNumber>0)
            {
                var reminder = givenNumber % 10;
                givenNumber = givenNumber / 10;
                reversenumber = reversenumber * 10 + reminder;
            }
            if (reversenumber==temp)
            {
                Console.WriteLine("is a palindram");
            }
            else
            {
                Console.WriteLine("not a  palindram");
            }

            Console.ReadLine();
        }
    }
}
