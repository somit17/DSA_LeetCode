public class Solution {
    public IList<IList<int>> FindSubsequences(int[] nums) {
        List<IList<int>> result = new List<IList<int>>();
        List<int> current = new();
        Backtrack(nums,0,current,result);
        return result;
    }


    void Backtrack(int[] nums,int idx,List<int> current,List<IList<int>> result){
        if(current.Count>=2){
            result.Add(new List<int>(current));
        }
        HashSet<int> seen = new HashSet<int>();
        //
        for(int i=idx;i<nums.Length;i++){
            // Skip invalid candidates:
            // 1. Duplicate values at the same level
            // 2. Values that break the non-decreasing property
            if (seen.Contains(nums[i]) || (current.Count > 0 && nums[i] < current[current.Count - 1])) {
                continue;
            }
                // Mark the current value as seen
            seen.Add(nums[i]);

            // Choose: Add the current element to the path
            current.Add(nums[i]);

            // Explore: Recursively call the function
            Backtrack(nums, i + 1, current, result);

            // Unchoose: Remove the last added element to backtrack
            current.RemoveAt(current.Count - 1);
            }
        }

    }
