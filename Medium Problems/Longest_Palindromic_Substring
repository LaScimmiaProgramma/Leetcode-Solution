public class Solution {
    public string LongestPalindrome(string s) {
        string longest = "";

        for (int i = 0; i < s.Length; i++) {
            int left = i, right = i;
            while (left >= 0 && right < s.Length && s[left] == s[right]) {
                left--;
                right++;
            }
            string odd = s.Substring(left + 1, right - left - 1);
            if (odd.Length > longest.Length) longest = odd;

            left = i; right = i + 1;
            while (left >= 0 && right < s.Length && s[left] == s[right]) {
                left--;
                right++;
            }
            string even = s.Substring(left + 1, right - left - 1);
            if (even.Length > longest.Length) longest = even;
        }

        return longest;
    }
}