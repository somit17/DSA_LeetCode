public class Solution {
    public void ReverseString(char[] s) {
        int L=0,R=s.Length-1;
        while(L<R){
            var temp = s[R];
            s[R]=s[L];
            s[L]=temp;
            L++;
            R--;
        }
    }
}