public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var dict = new Dictionary<char, int>();
        int maxLen = 0;
        int L = 0;
        
        for(int R = 0; R < s.Length; R++){
            if(dict.ContainsKey(s[R]))
                L = Math.Max(L, dict[s[R]] + 1);
            
            dict[s[R]] = R;
            maxLen = Math.Max(maxLen, R - L + 1);
        }
        
        return maxLen;
    }
}