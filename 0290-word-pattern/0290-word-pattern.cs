public class Solution {
    public bool WordPattern(string pattern, string s) {
        var splitString = s.Split(' ');
        if(pattern.Length!=splitString.Length)
            return false;
        Dictionary<char,string> mapCW = new Dictionary<char,string>();
        Dictionary<string,char> mapWC = new Dictionary<string,char>();
        for(int i=0;i<pattern.Length;i++){
            if((mapCW.ContainsKey(pattern[i]) && mapCW[pattern[i]]!=splitString[i])||
            (mapWC.ContainsKey(splitString[i]) && mapWC[splitString[i]]!=pattern[i])
            ){
                return false;
            }else{
                mapCW[pattern[i]]=splitString[i];
                mapWC[splitString[i]]=pattern[i];
            }
        }
        return true;
    }
}