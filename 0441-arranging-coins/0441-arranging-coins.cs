public class Solution {
    public int ArrangeCoins(int n) {
        if(n==0) return 0;
        long L=1,R=n;
        int result=0;
        while(L<=R){
            long mid = L+(R-L)/2;
            long sum = mid*(mid+1)/2;
            if (sum <= n) {
                result = (int)mid; // Update result
                L = mid + 1; // Search for a larger k
            } else {
                R = mid - 1; // Search for a smaller k
            }
        }
        return result;
    }
}