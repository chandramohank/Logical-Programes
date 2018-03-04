using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelDemo
{
    
    class Program
    {
        public static int Sum()
        {
            var watch = Stopwatch.StartNew();
            var sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum=sum+i;
            }
            Console.WriteLine(watch.ElapsedMilliseconds);
            watch.Stop();
            return sum;
          
           
        }
        public static int SumUsingParallerl()
        {
            var watch = Stopwatch.StartNew();
            var sum = 0;
            Parallel.For(0, 10, (i) => { sum = sum + i; });
            Console.WriteLine(watch.ElapsedMilliseconds);
            watch.Stop();
            return sum;
            
        }
        static void Main(string[] args)
        {
            Sum();
            SumUsingParallerl();
            Console.ReadLine();
        }
    }
}
