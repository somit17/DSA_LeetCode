public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if(s.Length!=t.Length){
            return false;
        }
        Dictionary<char,char> map1 = new Dictionary<char,char>(); //s->t
        Dictionary<char,char> map2 = new Dictionary<char,char>(); //t->s
        for(int i=0;i<s.Length;i++){
            if((map1.ContainsKey(s[i]) && map1[s[i]]!=t[i])
            ||
               (map2.ContainsKey(t[i]) && map2[t[i]]!=s[i])
            ){
                return false;
            }else{
                map1[s[i]]=t[i];
                map2[t[i]]=s[i];
            }
        }
        return true;
    }
}