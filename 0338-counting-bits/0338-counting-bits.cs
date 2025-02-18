public class Solution {
    public int[] CountBits(int n) {
        int[] result = new int[n+1];
        for(int i=0;i<=n;i++){
            result[i]=CountOnes(i);
        }
        return result;
    }
    public int CountOnes(int num){
        int c = 0;
        for(int bit=0;bit<32;bit++){
            if ((num & (1 << bit)) != 0) {
            c++;
            }
        }
        return c;
    }
}