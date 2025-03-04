public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int n=nums.Length;
        int leftMost = findLeftMost(nums,target,n);
        int rightMost = findRightMost(nums,target,n);
        return new [] {leftMost,rightMost};
    }

    public int findLeftMost(int[] nums,int target,int n){
        int l=0,r=n-1;
        int leftMost=-1;
        while(l<=r){
            int mid = l+(r-l)/2;
            if(nums[mid]==target){
                leftMost=mid;//possibly the answer
                r=mid-1;
            }else if(nums[mid]>target){
                r=mid-1;
            }else{
                l=mid+1;
            }
        }
        return leftMost;
    }

    public int findRightMost(int[] nums,int target,int n){
        int l=0,r=n-1;
        int rightMost=-1;
        while(l<=r){
            int mid = l+(r-l)/2;
            if(nums[mid]==target){
                rightMost=mid;//possibly the answer
                l=mid+1;
            }else if(nums[mid]>target){
                r=mid-1;
            }else{
                l=mid+1;
            }
        }
        return rightMost;
    }
}