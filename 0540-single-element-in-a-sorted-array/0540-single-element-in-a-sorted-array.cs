public class Solution {
    public int SingleNonDuplicate(int[] nums) {
        //Approach 1 using Hashmap
        return GetNonDuplicate(nums);
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