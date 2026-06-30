public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        for(int i=0;i<prices.Length;i++){
            int profit = 0;
            for(int j=i+1;j<prices.Length;j++){
                profit = Math.Max(prices[j]-prices[i],profit);
            }
            maxProfit = Math.Max(maxProfit, profit);
        }
        return maxProfit;
    }
}
