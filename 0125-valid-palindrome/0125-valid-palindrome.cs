public class Solution {
    public bool IsPalindrome(string s) {
        List<char> result = new List<char>();
        foreach(var ch in s){
            if(Char.IsLetterOrDigit(ch))
                result.Add(Char.ToLower(ch));
        }
        int L=0,R=result.Count-1;
        while(L<R){
            if(result[L]!=result[R]){
                return false;
            }
            L++;
            R--;
        }
        return true;
    }
}