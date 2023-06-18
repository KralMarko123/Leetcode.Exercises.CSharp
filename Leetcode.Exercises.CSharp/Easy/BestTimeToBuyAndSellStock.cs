
namespace Leetcode.Exercises.CSharp.Easy
{
    // You are given an array prices where prices[i] is the price of a given stock on the ith i.
    // You want to maximize your profit by choosing a single i to buy one stock and choosing a different i in the future to sell that stock.
    // Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.
    public static class BestTimeToBuyAndSellStock
    {
        public static int MaxProfit(int[] prices)
        {
            if (prices.Length == 1) return 0;
            
            var maxProfit = 0;
            var cheapestStockDay = 0;

            for (var dayOFStock = 1; dayOFStock < prices.Length; dayOFStock++)
            {
                if (prices[dayOFStock] - prices[cheapestStockDay] > maxProfit) maxProfit = prices[dayOFStock] - prices[cheapestStockDay];
                if (prices[dayOFStock] < prices[cheapestStockDay]) cheapestStockDay = dayOFStock;
            }

            return maxProfit;
        }
    }
}
