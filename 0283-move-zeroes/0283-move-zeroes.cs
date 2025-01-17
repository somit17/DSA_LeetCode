public class Solution {
    public void MoveZeroes(int[] nums) {
      int lastZeros = 0;
      for(int i=0;i<nums.Length;i++){
        if(nums[i]!=0){
            (nums[lastZeros],nums[i])=(nums[i],nums[lastZeros]);
            lastZeros++;
        }
      }
    }
}