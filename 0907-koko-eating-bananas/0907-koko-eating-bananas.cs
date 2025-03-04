public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int n=piles.Length;
        int L=1,R=piles.Max();
        while(L<R){
            int mid = L+(R-L)/2;
            if(CanEatAllBananas(piles,mid,h)){
                R=mid;
            }else{
                L=mid+1;
            }
        }
        return L;
    }

    bool CanEatAllBananas(int[] piles,int mid, int h){
        int actualHours = 0;
        foreach(var x in piles){
            actualHours+=(x/mid); //hours
            if((x%mid)!=0){
                actualHours++;
            }
        }
        return actualHours<=h;
    }
}