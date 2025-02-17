public class Solution {
    public int MaxProfit(int[] prices) {
        int L=0,R=1;
        int maxProfit = 0;
        while(R<prices.Length){
            if(prices[L]<prices[R]){
                maxProfit = Math.Max(maxProfit,prices[R]-prices[L]);
            }else{
                L=R;
            }
            R++;
        }
        return maxProfit;
    }
}