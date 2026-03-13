public class Solution {
    public int Reverse(int x) {
        string s = x.ToString();
        bool negative = s[0] == '-';
        if (negative) s = s.Substring(1);

        string reversed = new string(s.Reverse().ToArray());

        if (negative) reversed = "-" + reversed;
        
        int result;
        if (!int.TryParse(reversed, out result)) return 0;
        return result;
    }
}