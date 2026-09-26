public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        int n = prices.Length;
        int l = 0, r= 1;
        while(l < n && r < n){
            if(prices[l] < prices[r]){
                int currentProfit = prices[r] - prices[l];
                profit = Math.Max(profit, currentProfit);
                r++;
            }
            else{
                l = r;
                r++;
            }
        }
        return profit;
    }
}
