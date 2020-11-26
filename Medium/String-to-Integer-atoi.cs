public class Solution{
    public int MyAtoi(string str) {
        int newNum = 0, num = 0, len = str.Length;
        if (str == null || len < 1) { return 0; }

        int i;
        for(i = 0; i < len && str[i] ==' '; ++i){}

        if (i == len) return 0;

        bool isNeg = false;

        if (str[i] == '+') { i++; }
        else if (str[i] == '-') { isNeg = true;  i++; }

        

        for(int j=i; j < len; ++j){

            if (str[j] < '0' || str[j] > '9') { break; }            
            newNum = num * 10 + ((isNeg)? - (str[j]-'0'): (str[j]-'0'));            
            if (newNum/10 != num) { num = (isNeg)? int.MinValue: int.MaxValue; break; }
            num = newNum;
        }

            return num;
    }
}
