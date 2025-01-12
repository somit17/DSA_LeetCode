public class Solution {
    public int[] FrequencySort(int[] nums) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        foreach(var num in nums){
            if(map.ContainsKey(num)){
                map[num]++;
            }else{
                map[num]=1;
            }
        }
        return nums.OrderBy(x => map[x])     // First sort by frequency
                  .ThenByDescending(x => x)  // Then sort by value in       descending order for equal frequencies
                  .ToArray();
    }
}