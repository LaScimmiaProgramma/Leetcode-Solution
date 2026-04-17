import bisect

class Solution(object):
    def solveQueries(self, nums, queries):
        n = len(nums)
        result = []
        d = {}
        for i, num in enumerate(nums):
            d.setdefault(num, []).append(i)
        for i, key in enumerate(queries):
            indices = d[nums[key]]
            if len(indices) == 1:
                result.append(-1)
            else:
                k = bisect.bisect_left(indices, key)
                nextnum = indices[(k - 1) % len(indices)]
                prevnum = indices[(k + 1) % len(indices)]
                dist_next = abs(key - nextnum)
                dist_next = min(dist_next, n - dist_next)
                dist_prev = abs(key - prevnum)
                dist_prev = min(dist_prev, n - dist_prev)
                result.append(min(dist_next, dist_prev))
        return result
