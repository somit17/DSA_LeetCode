public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var group = new Dictionary<string,IList<string>>();
        foreach(var str in strs){
            char[] hash = new char[26];
            foreach(var ch in str){
                hash[ch-'a']++;
            }
            string groupKey = new string(hash);
            if(!group.ContainsKey(groupKey)){
                group[groupKey]=new List<string>();
            }
            group[groupKey].Add(str);
        }
        return group.Values.ToList();
    }
}