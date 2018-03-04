using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoSortedArrays
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 7, 9, 10  };
            int[] arr2 = new int[] { 1, 8,11,12 };

            int[] temp = new int[arr1.Length + arr2.Length];

            int i = 0, mid = temp.Length / 2, c = temp.Length;
            int k = 0;
            int j = 0;
            while (i < mid && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    temp[k] = arr1[i];
                    i++;
                    k++;
                }
                else
                {
                    temp[k] = arr2[j];
                    j++;
                    k++;
                }
            }

            while (i < mid)
            {
                temp[k] = arr1[i];
                i++;
                k++;
            }
            while (j < arr2.Length)
            {
                temp[k] = arr2[j];
                j++;
                k++;
            }

            Console.WriteLine(string.Join(",", temp));
            Console.ReadLine();
        }
    }
}
