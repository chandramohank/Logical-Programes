class Solution:
    def removeDuplicates(self,arr, n): 
        if n == 0 or n == 1: 
            return n 
    
        # To store index of next 
        # unique element 
        j = 0
    
        # Doing same as done 
        # in Method 1 Just 
        # maintaining another  
        # updated index i.e. j 
        for i in range(0, n-1): 
            if arr[i] != arr[i+1]: 
                arr[j] = arr[i] 
                j += 1
    
        arr[j] = arr[n-1] 
        j += 1
        return j
sol = Solution()
nums = [1, 2, 2, 3, 4, 4, 4, 5, 5]
n = sol.removeDuplicates(nums,len(nums))
for i in range(0, n): 
    print (" %d "%(nums[i]), end = " ") 