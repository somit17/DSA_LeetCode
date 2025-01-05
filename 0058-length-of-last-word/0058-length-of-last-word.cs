public class Solution {
    public int LengthOfLastWord(string s) {
        var split =s.Trim().Split(' ');
        return split[split.Length-1].Length;
    
    }
}