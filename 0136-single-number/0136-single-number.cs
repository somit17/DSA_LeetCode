public class Solution {
    public int SingleNumber(int[] nums) {
        int xorResult=0;
        foreach(var num in nums){
            xorResult^=num;
        }
        return xorResult;
    }
}