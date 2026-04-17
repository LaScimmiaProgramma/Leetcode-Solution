class Solution(object):
    def closestTarget(self, words, target, startIndex):
        n = len(words)
        res = float('inf')
        for i, word in enumerate(words):
            if word == target:
                dist = abs(i - startIndex)
                dist = min(dist, n - dist)
                res = min(res, dist)
        
        return res if res != float('inf') else -1
