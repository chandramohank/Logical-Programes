using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        public static void mostrepeatingnumber()
        {

            //Find most repeating word in array
            int[] array = new int[] { 1, 3, 5, 4, 5, 2, 5, 1, 4 };
            var res = array.GroupBy(x => x).OrderByDescending(x => x.Count()).FirstOrDefault().FirstOrDefault();
        }

        public static bool isPalindram(int Number)
        {

            int rev = 0;
            int original = Number;
            while (Number > 0)
            {
                int remainder = Number % 10;
                rev = rev * 10 + remainder;
                Number = Number / 10;
            }


            Console.WriteLine(string.Format("Plaindram:{0}  {1}", original, original == rev));
            return original == rev;
        }

        public static void Fibnocii(int a, int b, int counter, int number)
        {
            Console.WriteLine(a);
            if (counter < number)
            {
                Fibnocii(b, a + b, counter + 1, number);
            }

        }

        public static void MergeSort(int start, int mid, int end, int[] arr)
        {
            int[] newarr = new int[end - start + 1];
            int i = start;
            int j = mid + 1;
            int k = 0;
            while (i <= mid && j <= end)
            {
                if (arr[i] < arr[j])
                {
                    newarr[k] = arr[i];
                    i++;
                    k++;
                }
                else
                {
                    newarr[k] = arr[j];
                    j++;
                    k++;
                }
            }

            while (i <= mid)
            {
                newarr[k] = arr[i];
                i++;
                k++;
            }

            while (j <= end)
            {

                newarr[k] = arr[j];
                j++;
                k++;
            }
            foreach (int a in newarr)
            {
                Console.Write(a + " ");
            }

            Console.ReadLine();
        }

        public static void sortarray(int[] arr, int start, int end)
        {
            if (end > start)
            {
                int mid = (start + end) / 2;
                sortarray(arr, start, mid);
                sortarray(arr, mid + 1, end);
                MergeSort(start, mid, end, arr);
            }

        }

        public static void QuickSort(int[] arr, int start, int end)
        {
            if (arr.Length < 1)
            {
                return;
            }
            if (start < end)
            {
                int pivot = Partition(arr, start, end);
                if (pivot > 1)
                {
                    QuickSort(arr, start, pivot - 1);
                }
                if (pivot + 1 < end)
                {
                    QuickSort(arr, pivot+1, end);
                }
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);

            }
            Console.ReadLine();

        }

        //static public int Partition(int[] numbers, int left, int right)
        //{
        //    int pivot = numbers[left];
        //    while (true)
        //    {
        //        while (numbers[left] < pivot)
        //            left++;

        //        while (numbers[right] > pivot)
        //            right--;

        //        if (left < right)
        //        {
        //            int temp = numbers[right];
        //            numbers[right] = numbers[left];
        //            numbers[left] = temp;
        //            left++;
        //            right--;
        //        }
        //        else
        //        {
        //            return right;
        //        }
        //    }
        //}


        static void Main(string[] args)
        {
            mostrepeatingnumber();

            isPalindram(323);
            isPalindram(123);

            Fibnocii(0, 1, 0, 5);
            Console.ReadLine();

            //Merge sort
            int[] arr = { 5, 9, 11, 13, 2, 3, 6, 12 };
            sortarray(arr, 0, arr.Length - 1);
            Console.WriteLine("Using Quick Sort");
            int[] arr1 = { 87,49,23,43,16,12};
           // QuickSort_Recursive(arr1, 0, arr.Length - 1);

            Random rnd = new Random();
            DateTime startTime = DateTime.Now;

            int ind = 0;
            int length = 5;
            //int[] myArray = new int[length];

            //while (ind < 5)
            //{
            //    myArray[ind] = rnd.Next(5);
            //    ind++;
            //}
          int [] myArray={ 87,49,23,43,16};

            int lengthTwo = 5;

            Console.WriteLine("QuickSort by recursive method");

            QuickSort_Recursive(myArray, 0, lengthTwo - 1);

        }


        static public int Partition(int[] myArray, int left, int right)
        {
            int pivot = myArray[left];
            while (true)
            {
                while (myArray[left] < pivot)
                    left++;

                while (myArray[right] > pivot)
                    right--;

                if (left < right)
                {
                    int temp = myArray[right];
                    myArray[right] = myArray[left];
                    myArray[left] = temp;
                }
                else
                {
                    return right;
                }

            }
        }

        static public void QuickSort_Recursive(int[] arr, int left, int right)
        {
            // For Recusrion
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                    QuickSort_Recursive(arr, left, pivot - 1);

                if (pivot + 1 < right)
                    QuickSort_Recursive(arr, pivot + 1, right);
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
