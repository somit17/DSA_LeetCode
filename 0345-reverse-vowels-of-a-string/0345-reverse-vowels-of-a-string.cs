public class Solution {
    public bool isVowel(char c){
        if(c=='a'||c=='e'||c=='i'||c=='o'||c=='u'||
            c=='A'||c=='E'||c=='I'||c=='O'||c=='U'
        ){
            return true;
        }
        return false;
    }
    public string ReverseVowels(string s) {
        char[] chars = s.ToCharArray();
        int i=0,j=s.Length-1;
        while(i<j){
            if(!isVowel(chars[i])){
                i++;
            }else if(!isVowel(chars[j])){
                j--;
            }
            else{
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
                i++;
                j--;
            }
        }
        return new string(chars);
    }
}