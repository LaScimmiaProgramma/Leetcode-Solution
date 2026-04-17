public class Solution {
    public int MaximumAmount(int[][] coins) {
        int n = coins.Length;
        int m = coins[0].Length;
        
        int[,,] dp = new int[n, m, 3];
        
        // Caso base: cella di partenza (0,0)
        dp[0, 0, 0] = coins[0][0];
        dp[0, 0, 1] = Math.Max(0, coins[0][0]);
        dp[0, 0, 2] = Math.Max(0, coins[0][0]);
        
        // Prima riga
        for (int j = 1; j < m; j++)
        {
            dp[0, j, 0] = dp[0, j - 1, 0] + coins[0][j];
            dp[0, j, 1] = Math.Max(
                dp[0, j - 1, 1] + coins[0][j],
                dp[0, j - 1, 0] + Math.Max(0, coins[0][j])
            );
            dp[0, j, 2] = Math.Max(
                dp[0, j - 1, 2] + coins[0][j],
                dp[0, j - 1, 1] + Math.Max(0, coins[0][j])
            );
        }
        
        // Prima colonna
        for (int i = 1; i < n; i++)
        {
            dp[i, 0, 0] = dp[i - 1, 0, 0] + coins[i][0];
            dp[i, 0, 1] = Math.Max(
                dp[i - 1, 0, 1] + coins[i][0],
                dp[i - 1, 0, 0] + Math.Max(0, coins[i][0])
            );
            dp[i, 0, 2] = Math.Max(
                dp[i - 1, 0, 2] + coins[i][0],
                dp[i - 1, 0, 1] + Math.Max(0, coins[i][0])
            );
        }
        
        // Resto della griglia
        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < m; j++)
            {
                dp[i, j, 0] = Math.Max(dp[i - 1, j, 0], dp[i, j - 1, 0]) + coins[i][j];
                
                dp[i, j, 1] = Math.Max(
                    Math.Max(dp[i - 1, j, 1], dp[i, j - 1, 1]) + coins[i][j],
                    Math.Max(dp[i - 1, j, 0], dp[i, j - 1, 0]) + Math.Max(0, coins[i][j])
                );
                
                dp[i, j, 2] = Math.Max(
                    Math.Max(dp[i - 1, j, 2], dp[i, j - 1, 2]) + coins[i][j],
                    Math.Max(dp[i - 1, j, 1], dp[i, j - 1, 1]) + Math.Max(0, coins[i][j])
                );
            }
        }
        
        return Math.Max(dp[n - 1, m - 1, 0], Math.Max(dp[n - 1, m - 1, 1], dp[n - 1, m - 1, 2]));
    }
}
