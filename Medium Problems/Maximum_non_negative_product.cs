public class Solution {
    public int MaxProductPath(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        long[,] dpMax = new long[m, n];
        long[,] dpMin = new long[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == 0 && j == 0){
                    dpMax[0,0]=grid[0][0];
                    dpMin[0,0]=grid[0][0];
                }
                else if (i == 0){
                    dpMax[i,j] = Math.Max(grid[i][j] * dpMax[i,j-1], grid[i][j] * dpMin[i,j-1]);
                    dpMin[i,j] = Math.Min(grid[i][j] * dpMax[i,j-1], grid[i][j] * dpMin[i,j-1]);
                }
                else if (j == 0){
                    dpMax[i,j] = Math.Max(grid[i][j] * dpMax[i-1,j], grid[i][j] * dpMin[i-1,j]);
                    dpMin[i,j] = Math.Min(grid[i][j] * dpMax[i-1,j], grid[i][j] * dpMin[i-1,j]);
                } 
                else{
                dpMax[i,j] = Math.Max(Math.Max(grid[i][j] * dpMax[i-1,j], grid[i][j] * dpMin[i-1,j]),
                                    Math.Max(grid[i][j] * dpMax[i,j-1], grid[i][j] * dpMin[i,j-1]));

                dpMin[i,j] = Math.Min(Math.Min(grid[i][j] * dpMax[i-1,j], grid[i][j] * dpMin[i-1,j]),
                                    Math.Min(grid[i][j] * dpMax[i,j-1], grid[i][j] * dpMin[i,j-1]));
                }
            }

        }
        if(dpMax[m-1, n-1] < 0) return -1;
        return (int)(dpMax[m-1, n-1] % (1000000007));  
    }
}