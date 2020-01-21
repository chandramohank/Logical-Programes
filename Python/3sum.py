class Solution:
    def threeSum(self, nums: []) -> [[]]:
        
        counts, res = {}, set()
        for n in nums: counts[n] = counts.get(n, 0) + 1
        if counts.get(0,0) >= 3: res.add((0,0,0)) # edge case
        
        # remove repeats that occur over 3 times
        for k,v in counts.items(): 
            if v > 2: counts[k] = 2 
        nums = [n for key,v in counts.items() for n in v*[key]]
        
        for i, a in enumerate(nums):
            for b in nums[i+1:]:
                c = -a -b # constraint: a + b + c = 0
                if c in counts and c!= a and c!= b: 
                    res.add(tuple(sorted([a,b,c])))
        
        return [list(n) for n in res]

sol = Solution()
sol.threeSum([-1, 0, 1, 2, -1, -4])