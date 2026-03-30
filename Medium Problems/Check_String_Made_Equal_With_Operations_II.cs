public class Solution {
    public bool CheckStrings(string s1, string s2) {
        int[] even = new int[26];
        int[] odd = new int[26];

        for (int i = 0; i < s1.Length; i++) {
            if (i % 2 == 0) {
                even[s1[i] - 'a']++;
                even[s2[i] - 'a']--;
            } else {
                odd[s1[i] - 'a']++;
                odd[s2[i] - 'a']--;
            }
        }

        return even.All(v => v == 0) && odd.All(v => v == 0);
    }
}
