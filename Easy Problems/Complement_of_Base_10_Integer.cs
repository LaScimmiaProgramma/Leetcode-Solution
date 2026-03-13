public class Solution {
    public int BitwiseComplement(int n)
    {
        if (n == 0) return 1;
        
        string binary = "";
        int temp = n;
        
        while (temp > 0)
        {
            binary = (temp % 2 == 0 ? "1" : "0") + binary;
            temp /= 2;
        }
        
        int result = 0;
        int multiplier = 1;
        
        for (int i = binary.Length - 1; i >= 0; i--)
        {
            result += (binary[i] - '0') * multiplier;
            multiplier *= 2;
        }
        
        return result;
    }
}