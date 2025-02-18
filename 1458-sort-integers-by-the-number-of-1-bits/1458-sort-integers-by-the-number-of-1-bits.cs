public class Solution {
    public int[] SortByBits(int[] arr) {
        return arr.OrderBy(num => CountOnes(num)).ThenBy(num => num).ToArray();
    }
    public int CountOnes(int num){
        int count =0;
        for(int bit=0;bit<32;bit++){
            if((num &(1<<bit))!=0){
                count++;
            }
        }
        return count;
    }
}