namespace LogicalProgramingQuestions
{
    public static class ClosestNumber
    {
        public static int FindClosestNumber(int n, int[] arr, int start, int end)
        {

            if (n <= arr[start])
            {
                return arr[start];
            }
            if (n >= arr[end])
            {
                return arr[end];
            }
            if ((end - start) == 1)
            {
                return GetClosest(arr[start], arr[end], n);
            }
            else
            {
                if (start < end)
                {
                    var mid = (start + end) / 2;
                    if (arr[mid + 1] > n)
                    {
                        return FindClosestNumber(n, arr, start, mid);
                    }
                    else
                    {
                        return FindClosestNumber(n, arr, mid + 1, end);
                    }
                }
                else
                {
                    return arr[start];
                }
            }
        }

        public static int GetClosest(int value1, int value2, int target)
        {
            if (target - value1 >= value2 - target)
            {
                return value2;
            }
            else
            {
                return value1;
            }
        }
    }
}
