public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        //Approach 1 using Hashmap
        //return GetNonDuplicate(nums);

        //Approach 2 using BS
        return GetNonDuplicateBS(nums);
    }

    public int GetNonDuplicateBS(int[] nums){
        int n = nums.Length;
        int l=0,r=n-1;
        while(l<r){
           int mid = l+(r-l)/2;
           bool isEven = (r-mid)%2==0;
            if(nums[mid] == nums[mid+1]) {
                if(isEven) {
                    l = mid+2;
                } else {
                    r = mid-1;
                }
            } else if(nums[mid] == nums[mid-1]) {
                if(isEven) {
                    r = mid-2;
                } else {
                    l = mid+1;
                }
            } else {
                return nums[mid];
            }
        }
        return nums[r];

    }
    public int GetNonDuplicate(int[] nums){
        Dictionary<int,int> dic = new();
        foreach(var num in nums){
            if(!dic.ContainsKey(num)){
                dic[num]=1;
            }else{
                dic[num]++;
            }
        }
        return dic.FirstOrDefault(x=>x.Value==1).Key; 
    }
}