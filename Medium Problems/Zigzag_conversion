public class Solution {
    public string Convert(string s, int numRows) {
        if(numRows==1) return s;
        string result = "";
        int gap =(numRows-1)*2;
        for(int row=0; row<numRows; row++){
            for(int i=row; i<s.Length; i+= gap){
                result+=s[i];
                int second = i +gap -(row*2);
                if(row!=0 && row!=numRows-1 && second<s.Length){
                    result+=s[second];
                }
            }
            
        }
        return result;
    }
}