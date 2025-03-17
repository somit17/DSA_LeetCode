public class Solution {
    List<string> result;
    Dictionary<char,string> map;
    int n;
    public IList<string> LetterCombinations(string digits) {
        if (string.IsNullOrEmpty(digits)) {
            return new List<string>();
        }
        map = new Dictionary<char, string>() {
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" }
        };

        result = new();
        string temp=string.Empty;
        n=digits.Length;
        Solve(digits,temp,0);
        return result;
    }
    public void Solve(string digits,string temp,int idx){
        if(idx == digits.Length)
        {
            result.Add(temp);
            return;
        }
        char digit = digits[idx];
        string letters = map[digit];
        foreach(var letter in letters){
            string newString = temp+letter;
            Solve(digits,newString,idx+1);
        }
    }
}