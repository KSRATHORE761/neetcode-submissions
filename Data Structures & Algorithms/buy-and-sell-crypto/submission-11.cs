public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int l=0;
        for(int r=0;r<prices.Length;r++){
            if(prices[r]>prices[l]){
                maxProfit = Math.Max(maxProfit, prices[r]-prices[l]);
            }
            else{
                l=r;
            }
        }
        return maxProfit;
    }
}
