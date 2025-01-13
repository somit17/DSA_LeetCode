public class Solution {
    public int[] SeparateDigits(int[] nums) {
        string s = string.Join("",nums);
        List<int> result = new List<int>();
        foreach(var ch in s){
            result.Add(ch-'0');
        }
        return result.ToArray();
    }
}