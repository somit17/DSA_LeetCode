public class Solution {
    int n;
    public IList<IList<string>> Partition(string s) {
        n=s.Length;
        List<IList<string>> result = new List<IList<string>>();
        List<string> current = new();
        BackTrack(s,0,current,result);
        return result;
    }

    void BackTrack(string s,int idx,List<string> current,List<IList<string>> result){
        if(idx==n){
            result.Add(new List<string>(current));
            return;
        }

        for(int i=idx;i<n;i++){
            if(IsValidPalindrome(s,idx,i)){
                current.Add(s.Substring(idx, i - idx + 1));
                BackTrack(s,i+1,current,result);
                current.RemoveAt(current.Count-1);
            }
        }
    }

    bool IsValidPalindrome(string s,int L,int R){
        while(L<R){
            if(s[L]!=s[R])
                return false;
            L++;
            R--;
        }
        return true;
    }
}