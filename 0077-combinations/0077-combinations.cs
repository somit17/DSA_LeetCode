public class Solution {
    List<IList<int>> result;
    public IList<IList<int>> Combine(int n, int k) {
       result = new ();
       List<int> current = new();
       Solve(1,n,k,current);
       return result; 
    }
    void Solve(int start,int n,int k,List<int> current){
        if(k==0){
            result.Add(new List<int>(current));
            return;
        }
        if(start>n)
            return ;
        current.Add(start);
        Solve(start+1,n,k-1,current);
        current.RemoveAt(current.Count-1);
        Solve(start+1,n,k,current);
    }
}