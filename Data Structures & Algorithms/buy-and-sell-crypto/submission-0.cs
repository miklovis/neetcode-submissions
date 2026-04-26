public class Solution {
    public int MaxProfit(int[] prices) {
        var maxProfit = 0;


        for(int i = 0; i < prices.Length - 1; i++) {
            for(int j = i+1; j < prices.Length; j++) {
                if(prices[j] <= prices[i]) {
                    continue;
                }

                var currentProfit = prices[j] - prices[i];
                if(currentProfit > maxProfit) {
                    maxProfit = currentProfit;
                }
            }
        }

        return maxProfit;
    }
}
