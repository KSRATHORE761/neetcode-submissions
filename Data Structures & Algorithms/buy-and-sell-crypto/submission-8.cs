public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices == null || prices.Length==0) return 0;
        int maxProfit = 0;
        for(int i=0;i<prices.Length;i++){
            int profit = 0;
            for(int j = i+1;j<prices.Length;j++){
                if(prices[j]>prices[i]){
                    profit = Math.Max(profit,(prices[j]-prices[i]));
                }
            }
            maxProfit = Math.Max(maxProfit,profit);
        }
        return maxProfit;
    }
}
