public class Solution {
    public int MySqrt(int x) {
        long low = 1, high = x;
        while (low <= high)
        {
            long mid = (low + high) / 2;
            long val = mid * mid;
            if (val<=x)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return Convert.ToInt32(high);
    }
}