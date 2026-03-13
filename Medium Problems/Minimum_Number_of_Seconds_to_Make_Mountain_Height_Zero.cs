public class Solution {
    public long MinNumberOfSeconds(int mountainHeight, int[] workerTimes) {
        long min = 0;
        long max = (long)workerTimes.Max() * mountainHeight * (mountainHeight + 1) / 2;
        
        while (min < max) {
            long mid = (min + max) / 2;
            
            if (TotalUnits(workerTimes, mid) >= mountainHeight)
                max = mid;
            else
                min = mid + 1;
        }
        
        return min;
    }
    
    int TotalUnits(int[] workerTimes, long T) {
        int total = 0;
        for (int i = 0; i < workerTimes.Length; i++)
            total += MaxUnits(workerTimes[i], T);
        return total;
    }
    
    int MaxUnits(int w, long T) {
        double val = 2.0 * T / w;
        int x = (int)((-1 + Math.Sqrt(1 + 4 * val)) / 2);
        return x;
    }
}