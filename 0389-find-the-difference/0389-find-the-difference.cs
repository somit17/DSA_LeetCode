public class Solution {
    public char FindTheDifference(string s, string t) {
        // Dictionary<char,int> map = new();
        // foreach(var ch in s){
        //     if(!map.ContainsKey(ch)){
        //         map[ch]=1;
        //     }else{
        //         map[ch]++;
        //     }
        // }
        // foreach(var ch in t){
        //     if(!map.ContainsKey(ch)){
        //         return ch;
        //     }else{
        //         map[ch]--;
        //         if(map[ch]==-1)
        //             return ch;
        //     }
        // }
        // return 'x';


        int XOR = 0;
        foreach(var ch in s){
            XOR^=ch;
        }
        foreach(var ch in t){
            XOR^=ch;
        }
        return (char)XOR;
    }
}