public class Solution {
    public int NumIdenticalPairs(int[] nums) {
      int[] frequencyArray = new int[102];
        foreach(var num in nums)
        {
            frequencyArray[num]++;
        }
        int totalCount = 0;
        foreach(int i in frequencyArray)
        {
            totalCount = totalCount+((i)*(i-1))/2;
        }
        return totalCount;  
    }
}