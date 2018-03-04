using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Delegate_Func
{
    /*Action */
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Part 1 - First action that takes an int and converts it to hex
    //        Action<int> displayHex = delegate(int intValue)
    //        {
    //            Console.WriteLine(intValue.ToString("X"));
    //        };

    //        // Part 2 - Second action that takes a hex string and 
    //        // converts it to an int
    //        Action<string> displayInteger = delegate(string hexValue)
    //        {
    //            Console.WriteLine(int.Parse(hexValue,
    //                System.Globalization.NumberStyles.HexNumber));
    //        };

    //        // Part 3 - exercise Action methods
    //        displayHex(16);
    //        displayInteger("10");
    //    }
    //}
    /*Func */
    class FuncExampe
    {
        public static string[] result(Func<string,bool> filter,string[] fruits)
        {
           return fruits.Where(filter).ToArray();
        }
        static void Main(string[] args)
        {
            var fruits = new string[] { "chandramohan", "harish", "srinu", "sdadaddad", "sai", "navinsomani" };
            
            var largeFruits = result(c => c.Length > 6, fruits);
            Console.WriteLine(string.Join(",",largeFruits));
            Console.ReadLine();
            var shortFruits = result(c => c.Length < 6, fruits);
            Console.WriteLine(string.Join(",", shortFruits));
            Console.ReadLine();
        }

       
    }
}
