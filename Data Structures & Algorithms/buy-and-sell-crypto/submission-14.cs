public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0;
        int l=0, r=1;
        int n = prices.Length;
        while(l<n && r<n){
            if(prices[r] > prices[l]){
                profit = Math.Max(profit, prices[r]-prices[l]);
            }
            else{
                l=r;
            }
            r++;
        }
        return profit;
    }
}
