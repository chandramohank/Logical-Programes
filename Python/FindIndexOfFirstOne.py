#Find the index of first 1 in a sorted array of 0’s and 1’s

# Python3 implementation to find 
# the index of first '1' in a 
# sorted array of 0's and 1's
 
# function to find the index of first '1'
# binary search technique is applied
def indexOfFirstOne( arr, low, high):
 
    while (low <= high):
         
        mid = int((low + high) / 2)
 
        # if true, then 'mid' is the index of first '1'
        if (arr[mid] == 1 and (mid == 0 or arr[mid - 1] == 0)):
            return mid
 
        # first '1' lies to the left of 'mid'
        elif (arr[mid] == 1):
            high = mid - 1
 
        # first '1' lies to the right of 'mid'
        else:
            low = mid + 1
     
 
    # 1's are not present in the array
    return -1;
 
# Driver program to test above
arr = [0, 0, 0, 0, 0, 0, 1, 1, 1, 1 ]
n = len(arr)
ans = indexOfFirstOne(arr, 0, n - 1)
print (ans)
 