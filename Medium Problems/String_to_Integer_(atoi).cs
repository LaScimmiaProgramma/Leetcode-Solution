public class Solution {
    public int MyAtoi(string s) {
        int i = 0;
        int sign = 1;
        long result = 0;

        while (i < s.Length && s[i] == ' ') i++;

        if (i < s.Length && (s[i] == '-' || s[i] == '+')) {
            sign = s[i] == '-' ? -1 : 1;
            i++;
        }

        while (i < s.Length && char.IsDigit(s[i])) {
            result = result * 10 + (s[i] - '0');
            i++;

            if (result * sign > int.MaxValue) return int.MaxValue;
            if (result * sign < int.MinValue) return int.MinValue;
        }

        return (int)(result * sign);
    }
}