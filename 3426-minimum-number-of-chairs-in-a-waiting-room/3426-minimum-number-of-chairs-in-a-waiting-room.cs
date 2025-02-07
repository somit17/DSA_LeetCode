public class Solution {
    public int MinimumChairs(string s) {
        int people=0,maxPeople=-1;
        int l=s.Length;
        foreach(var ch in s){
            if(ch=='E'){
                people++;
            }else{
                people--;
            }
            maxPeople=Math.Max(people,maxPeople);
        }
        return maxPeople;
    }
}