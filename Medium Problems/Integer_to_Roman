public class Solution {
    public string IntToRoman(int num) {
        string result = "";
        int c = 1;

        while (num != 0) {
            int number = num % 10;

            switch (number) {
                case 1 when c == 1: result = "I" + result; break;
                case 2 when c == 1: result = "II" + result; break;
                case 3 when c == 1: result = "III" + result; break;
                case 4 when c == 1: result = "IV" + result; break;
                case 5 when c == 1: result = "V" + result; break;
                case 6 when c == 1: result = "VI" + result; break;
                case 7 when c == 1: result = "VII" + result; break;
                case 8 when c == 1: result = "VIII" + result; break;
                case 9 when c == 1: result = "IX" + result; break;
                case 1 when c == 2: result = "X" + result; break;
                case 2 when c == 2: result = "XX" + result; break;
                case 3 when c == 2: result = "XXX" + result; break;
                case 4 when c == 2: result = "XL" + result; break;
                case 5 when c == 2: result = "L" + result; break;
                case 6 when c == 2: result = "LX" + result; break;
                case 7 when c == 2: result = "LXX" + result; break;
                case 8 when c == 2: result = "LXXX" + result; break;
                case 9 when c == 2: result = "XC" + result; break;
                case 1 when c == 3: result = "C" + result; break;
                case 2 when c == 3: result = "CC" + result; break;
                case 3 when c == 3: result = "CCC" + result; break;
                case 4 when c == 3: result = "CD" + result; break;
                case 5 when c == 3: result = "D" + result; break;
                case 6 when c == 3: result = "DC" + result; break;
                case 7 when c == 3: result = "DCC" + result; break;
                case 8 when c == 3: result = "DCCC" + result; break;
                case 9 when c == 3: result = "CM" + result; break;
                case 1 when c == 4: result = "M" + result; break;
                case 2 when c == 4: result = "MM" + result; break;
                case 3 when c == 4: result = "MMM" + result; break;
            }

            num /= 10;
            c++;
        }

        return result;
    }
}