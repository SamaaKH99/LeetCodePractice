public class Solution {
    public int MaxProfit(int[] prices) {
        
        int minprice = int.MaxValue;
        int maxprofit = 0;
        
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minprice)
            {
                minprice = prices[i];
            }
            else if (prices[i] - minprice > maxprofit)
            {
                maxprofit = prices[i] - minprice;
            }
        }
        
        return maxprofit;
    }
}

// 1  2  3  4  5  6
// 7, 1, 5, 3, 6, 4