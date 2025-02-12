public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        //Approach 1 hastable 
        Dictionary<int,int> hash = new Dictionary<int,int>();
        foreach(var num in nums){
            if(hash.ContainsKey(num)){
                return true;
            }else{
                hash[num]=1;
            }
        }
        return false;
    }
}