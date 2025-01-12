public class Solution {
    public int[] RunningSum(int[] nums) {
        int previousVal =0;
        for(int i=0;i<nums.Length;i++){
            nums[i]=previousVal+nums[i];
            previousVal=nums[i];
        }
        return nums;
    }
}