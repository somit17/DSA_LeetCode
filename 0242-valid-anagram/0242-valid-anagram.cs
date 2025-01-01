public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int> map = new Dictionary<char,int>();
        if(s.Length!=t.Length){
            return false;
        }
        foreach(var ch in s)
        {
            if(map.ContainsKey(ch)){
                map[ch]++;
            }else{
                map[ch]=1;
            }
        }
        foreach(var ch in t){
            if(map.ContainsKey(ch) && map[ch]>0){
                map[ch]--;
            }else{
                return false;
            }
        }
        return true;
    }
}