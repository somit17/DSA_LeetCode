public class Solution {
    public int MaxProduct(int[] nums) {
        int largest = 0,secondLargest = 0;
        foreach(var num in nums){
            if(num>largest){
                secondLargest=largest;
                largest=num;
            }else{
                secondLargest=Math.Max(secondLargest,num);
            }
        }
        return (largest-1)*(secondLargest-1);
    }
}