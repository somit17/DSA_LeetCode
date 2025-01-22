public class Solution {
    public int SearchInsert(int[] nums, int target) {
        return BinarySearch(nums,target);
    }
    public int BinarySearch(int[] nums,int target){
        int L=0,R=nums.Length-1;
        while(L<=R){
            int mid=(L+R)/2;
            if(nums[mid]>target){
                R=mid-1;
            }else if(nums[mid]<target){
                L=mid+1;
            }else{
                return mid;
            }
        }
        return L;
    }
}