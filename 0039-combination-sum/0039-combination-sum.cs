public class Solution {
    List<IList<int>> result;
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        result = new();
        List<int> temp = new();
        Solve(candidates,target,temp,0);
        return result;
    }
    public void Solve(int[] candidates, int target,List<int> temp,int start){
        if(temp.Sum() >target)
            return;
        if(temp.Sum()==target){
            result.Add(new List<int>(temp));
            return;
        }
        for(int i=start;i<candidates.Length;i++){
            temp.Add(candidates[i]);
            Solve(candidates,target,temp,i);
            temp.RemoveAt(temp.Count-1);
        }
    }

}