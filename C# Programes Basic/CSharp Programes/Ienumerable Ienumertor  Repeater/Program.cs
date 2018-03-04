using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ienumerable_Ienumertor__Repeater
{
    class Program
    {
        static IEnumerable<string> GetDemoEnumerable() 
        {
            yield return "start";
            for (int i = 0; i < 5; i++)
			{
                yield return i.ToString();
			}

            yield return "End";
        }
        static void Main(string[] args)
        {
            foreach (var item in GetDemoEnumerable())
            {
                Console.WriteLine(item);
                
            }

            Console.ReadLine();
        }
    }
}
