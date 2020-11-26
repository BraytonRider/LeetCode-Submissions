public class Solution {
    public int Maximum69Number (int num) {
        int bigger = 0;
        int[] digits = new int[] {0, 0, 0, 0};
        
        // parcing
        for(int i = 3; num != 0; --i){
            digits[i] = num % 10;
            num /= 10;
        }
        
        // changing one
        for(int i = 0; i < digits.Length; i++){
            if(digits[i] == 6){
                digits[i] = 9;
                break;
            }
        }
        
        //foreach(int i in digits) Console.WriteLine(i);
        
        //putting it back together
        for(int i = 0; i < digits.Length; i++){
            bigger += (digits[i] * Convert.ToInt32(Math.Pow(10, 3 - i)));
        }
     
        return bigger;
    }
    
}
