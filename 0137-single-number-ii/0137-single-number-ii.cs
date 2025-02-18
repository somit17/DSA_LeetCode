public class Solution {
    public int SingleNumber(int[] nums) {
        int result = 0;
        for(int bit=0;bit<32;bit++){
            int temp = (1<<bit);
            int cz=0,co=0;
            foreach(var num in nums){
                if((num&temp) == 0)
                    cz++;
                else
                    co++;
            }
            if(co%3==1){
                result = (result | temp);
            }
        }
        return result;
    }
}