public class Solution {
    List<IList<int>> result;
    HashSet<int> seen;
    int n;
    public IList<IList<int>> Permute(int[] nums) {
        result = new();
        List<int> current = new();
        n = nums.Length;
        seen=new();
        Solve(nums,n,current);
        return result;
    }
    public void Solve(int[] nums,int n,List<int> temp){
        if(temp.Count==n){
            result.Add(new List<int>(temp));
            return;
        }
        for(int i=0;i<n;i++){
            if(!seen.Contains(nums[i])){
                temp.Add(nums[i]);
                seen.Add(nums[i]);
                Solve(nums,n,temp);
                temp.RemoveAt(temp.Count-1);
                seen.Remove(nums[i]);
            }
        }
    }
}