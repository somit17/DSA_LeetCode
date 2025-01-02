public class Solution {
    public int NumIdenticalPairs(int[] nums) {
      Dictionary<int, int> counts = new Dictionary<int, int>();
        int totalCount = 0;
        foreach (var num in nums) {
            if (counts.ContainsKey(num)) {
                totalCount += counts[num]; // Add the count of `num` to `totalCount`
                counts[num]++; // Increment the count for `num`
            } else {
                counts[num] = 1; // Initialize the count for `num`
            }
        }
        
        return totalCount;
    }
}