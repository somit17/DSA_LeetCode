public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        HashSet<int> hash=new HashSet<int>(nums);
        IList<int> result = new List<int>();
        for (int i = 1; i <= nums.Length; i++) {
            if (!hash.Contains(i)) {
                result.Add(i); // Add the missing number to the result list
            }
        }
        return result;
    }
}