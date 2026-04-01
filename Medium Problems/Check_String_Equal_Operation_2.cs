public class Solution {
    public bool CheckStrings(string s1, string s2) {
        // I use two frequency arrays to track character balance at even and odd positions
        int[] even = new int[26];
        int[] odd = new int[26];

        for (int i = 0; i < s1.Length; i++) {
            if (i % 2 == 0) {
                // I increment for s1 and decrement for s2 at even positions
                // if they are swappable, the net balance must be zero
                even[s1[i] - 'a']++;
                even[s2[i] - 'a']--;
            } else {
                // I do the same for odd positions separately
                odd[s1[i] - 'a']++;
                odd[s2[i] - 'a']--;
            }
        }

        // I check that both even and odd positions have a perfect balance
        // if any character count is non-zero, the strings cannot be made equal
        return even.All(v => v == 0) && odd.All(v => v == 0);
    }
}
