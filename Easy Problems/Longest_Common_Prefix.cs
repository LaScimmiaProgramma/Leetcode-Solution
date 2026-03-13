public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string shortest = strs[0];
        for (int i = 1; i < strs.Length; i++) {
            if (strs[i].Length < shortest.Length)
                shortest = strs[i];
        }
        string result ="";
        for (int i = 0; i < shortest.Length; i++) { 
            for (int j = 0; j < strs.Length; j++) { 
                if (strs[j][i] != shortest[i]) 
                    return result;
            }
            result += shortest[i];
        }
        return result;

    }
}