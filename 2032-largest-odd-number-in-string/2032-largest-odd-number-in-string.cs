public class Solution {
    public string LargestOddNumber(string num) {
        int n = num.Length;
        for (int i = n - 1; i >= 0; i--) {
            if ((num[i] - '0') % 2 != 0) { // Check if the digit is odd
                return num.Substring(0, i + 1); // Return the substring up to this digit
            }
        }

        // If no odd digit is found, return an empty string
        return "";
    }
}