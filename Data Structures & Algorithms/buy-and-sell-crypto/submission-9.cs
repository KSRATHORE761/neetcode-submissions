public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices == null || prices.Length==0) return 0;
        int maxProfit = 0;
        int left=0;
        for(int right =1;right<prices.Length;right++){
            if(prices[right]>prices[left]){
                maxProfit = Math.Max(maxProfit, (prices[right]-prices[left]));
            }
            else{
                left = right;
            }
        }
        return maxProfit;
    }
}
