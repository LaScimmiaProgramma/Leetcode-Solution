public class Solution {
    public int RomanToInt(string s) {
        int num=0;
        bool lastConsumed = false;
        for(int i=0; i<s.Length-1; i++){
            if(s[i]=='I'&& s[i+1]!='V'&& s[i+1]!='X'){
                num+=1;
            }else if (s[i]=='I'&& (s[i+1]=='V'|| s[i+1]=='X')){
                if (s[i+1]=='V'){
                    num+=4;
                    if (i+1==s.Length-1) lastConsumed=true;
                    i++;
                }else{
                    num+=9;
                    if (i+1==s.Length-1) lastConsumed=true;
                    i++;     
                }
            }else if(s[i]=='V'){
                num+=5;
            }else if(s[i]=='X'&& s[i+1]!= 'L'&& s[i+1]!= 'C'){
                num+=10;
            }else if (s[i]=='X'&& (s[i+1]=='L'|| s[i+1]=='C')){
                if (s[i+1]=='L'){
                    num+=40;
                    if (i+1==s.Length-1) lastConsumed=true;
                    i++;
                }else {
                    num+=90;
                    if (i+1==s.Length-1) lastConsumed=true;
                    i++;
                }
            }else if(s[i]=='L'){
                num+=50;
            }else if(s[i]=='C'&& s[i+1]!='D'&& s[i+1]!= 'M'){
                num+=100;
            }else if (s[i]=='C'&& (s[i+1]=='D'|| s[i+1]=='M')){
                if (s[i+1]=='D'){
                    num+=400;
                    if (i+1==s.Length-1) lastConsumed=true;
                    i++;
                }else {
                    num+=900;
                    if (i+1==s.Length-1) lastConsumed=true;
                    i++;
                }
            }else if(s[i]=='D'){
                num+=500;
            }else if(s[i]=='M'){
                num+=1000;
            }
        }
        if (!lastConsumed){
            switch(s[s.Length-1]){
                case 'I': num+=1; break;
                case 'V': num+=5; break;
                case 'X': num+=10; break;
                case 'L': num+=50; break;
                case 'C': num+=100; break;
                case 'D': num+=500; break;
                case 'M': num+=1000; break;
            }
        }
        return num;
    }
}