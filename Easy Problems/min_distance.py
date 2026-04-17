class Solution(object):
    def getMinDistance(self, nums, target, start):
        min_d=1000
        for i, val in enumerate(nums):
            if target==val:
                if abs(i-start)<min_d :
                    min_d = abs(i-start)
        return min_d
