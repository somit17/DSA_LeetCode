public class Solution {
    public string MergeAlternately(string word1, string word2) {
        List<char> result = new List<char>();
        int L=0,R=0;
        while(L<word1.Length || R<word2.Length){
            if(L<word1.Length){result.Add(word1[L]);L++;};
            if(R<word2.Length){result.Add(word2[R]);R++;};
        }
        return string.Join("",result);
    }
}