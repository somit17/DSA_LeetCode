public class Solution {
    public int[] SortArray(int[] nums) {
        Dictionary<int,int> map = new(); //map
        foreach(var num in nums){
            if(map.ContainsKey(num)){
                map[num]++;
            } else {
                map[num] = 1;
            }
        }
        int min = nums.Min();
        int max = nums.Max();
        int i=0;
        for(int num=min;num<=max;num++){
            if(map.ContainsKey(num)){
                while(map[num]>0){
                    nums[i]=num;
                    i++;
                    map[num]--;
                }
            }
        }
        return nums;
    }
}