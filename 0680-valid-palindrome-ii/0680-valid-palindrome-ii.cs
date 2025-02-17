public class Solution {
    public bool ValidPalindrome(string s) {
        int L = 0, R = s.Length - 1;
        
        while (L < R) {
            if (s[L] != s[R]) {
                // Try skipping either the left character or the right character
                return IsPalindromeRange(s, L + 1, R) || IsPalindromeRange(s, L, R - 1);
            }
            L++;
            R--;
        }
        
        return true;  // If we exit the loop, the string is a valid palindrome
    }
    
    private bool IsPalindromeRange(string s, int left, int right) {
        while (left < right) {
            if (s[left] != s[right]) {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}