using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Implementations
{
    class Program
    {
        static void Main(string[] args)
        {
            StackArray<int> arr = new StackArray<int>();
            arr.Push(10);
            arr.Push(11);
            arr.Push(12);
            arr.Push(13);
            arr.Push(14);
            arr.Push(15);
            arr.Pop();
            arr.Pop();
            arr.Push(16);
            arr.Push(17);

            foreach (var item in arr.Display())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            QueueArray<int> arr1 = new QueueArray<int>();
            arr1.Push(10);
            arr1.Push(11);
            arr1.Push(12);
            arr1.Push(13);
            arr1.Push(14);
            arr1.Push(15);
            arr1.Pop();
            arr1.Pop();
            arr1.Push(16);
            arr1.Push(17);

            foreach (var item in arr1.Display())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
