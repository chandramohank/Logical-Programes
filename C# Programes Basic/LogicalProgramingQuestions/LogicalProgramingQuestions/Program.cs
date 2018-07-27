using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramingQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            //FindClosestNumber
            ////int[] arr = new int[] {1, 2, 3, 10, 17, 19, 21};

            
            ////var closestNumber = ClosestNumber.FindClosestNumber(8, arr, 0, arr.Length - 1);
            ////Console.WriteLine(closestNumber);

            ////TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] n1N2N3 = Console.ReadLine().Split(' ');

            int n1 = Convert.ToInt32(n1N2N3[0]);

            int n2 = Convert.ToInt32(n1N2N3[1]);

            int n3 = Convert.ToInt32(n1N2N3[2]);

            int[] h1 = Array.ConvertAll(Console.ReadLine().Split(' '), h1Temp => Convert.ToInt32(h1Temp))
            ;

            int[] h2 = Array.ConvertAll(Console.ReadLine().Split(' '), h2Temp => Convert.ToInt32(h2Temp))
            ;

            int[] h3 = Array.ConvertAll(Console.ReadLine().Split(' '), h3Temp => Convert.ToInt32(h3Temp))
            ;
            int result = equalStacks(h1, h2, h3);

            ////textWriter.WriteLine(result);

            ////textWriter.Flush();
            ////textWriter.Close();
        }

        /*
     * Complete the equalStacks function below.
     */
        static int equalStacks(int[] h1, int[] h2, int[] h3)
        {
            /*
             * Write your code here.
             */
            var s1 = h1.Sum();
            var s2 = h2.Sum();
            var s3 = h3.Sum();
            int h1l = h1.Length;
            int h2l = h2.Length;
            int h3l = h3.Length;
            int i = 0; int j = 0; int k = 0;
            //check all three sums are ture
            while (s1 != s2 || s2 != s3 || s1 != s3)
            {
                if (s1 >= s2 && s1 >= s3 && i < h1l)
                {
                    s1 = s1 - h1[i];
                    i++;
                }
                else if (s2 >= s1 && s2 >= s3 && j < h2l)
                {
                    s2 = s2 - h2[j];
                    j++;
                }
                else if (s3 >= s1 && s3 >= s2 && k < h3l)
                {
                    s3 = s3 - h3[k];
                    k++;
                }
                else if (s1 > s3 && s2 > s3 && i < h1l && j < h2l)
                {
                    s1 -= h1[i];
                    i++;
                    s2 -= h2[j];
                    j++;
                }
                else if (s1 > s2 && s3 > s2 && i < h1l && k < h3l)
                {
                    s1 -= h1[i];
                    i++;
                    s3 -= h3[k];
                    k++;
                }
                else if (j < h2l && k < h3l)
                {
                    s2 -= h2[j];
                    j++;
                    s3 -= h3[k];
                    k++;
                }
            }

            return s1;
        }
    }
}
