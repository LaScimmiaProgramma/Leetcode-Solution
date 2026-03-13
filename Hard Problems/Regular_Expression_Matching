public class Solution {
public bool IsMatch(string s, string p) {
        bool[,] dp = new bool[s.Length + 1, p.Length + 1];
        
        // caso base: stringa vuota matcha pattern vuoto
        dp[0, 0] = true;
        
        // prima riga: s è vuota
        for (int j = 2; j <= p.Length; j++) {
            if (p[j-1] == '*')
                dp[0, j] = dp[0, j-2];
        }
        
        // resto della tabella
        for (int i = 1; i <= s.Length; i++) {
            for (int j = 1; j <= p.Length; j++) {
                
                // caso 1: carattere normale o '.'
                if (p[j-1] == '.' || p[j-1] == s[i-1]) {
                    dp[i, j] = dp[i-1, j-1];
                }
                // caso 2 e 3: '*'
                else if (p[j-1] == '*') {
                    // zero occorrenze
                    dp[i, j] = dp[i, j-2];
                    
                    // una o più occorrenze
                    if (p[j-2] == '.' || p[j-2] == s[i-1])
                        dp[i, j] = dp[i, j] || dp[i-1, j];
                }
            }
        }
        
        return dp[s.Length, p.Length];
    }
}
