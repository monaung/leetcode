using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class StockMaxProfit
    {
        public int MaxProfit(int[] prices, int fee)
        {

            //int leftPointer = 0;
            //int rightPointer = 1;
            //int runningMax = 0;

            //while (rightPointer < prices.Length)
            //{
            //    if (prices[rightPointer] - prices[leftPointer] > 0)
            //    {
            //        runningMax = Math.Max(runningMax, prices[rightPointer] - prices[leftPointer]);
            //    }
            //    else
            //    {
            //        leftPointer = rightPointer;
            //    }
            //    rightPointer++;
            //}

            //return runningMax;

            //int max_profit = 0;

            //for (int i = 0; i < prices.Length; i++)
            //{
            //    for (int j = i; j < prices.Length; j++)
            //    {
            //        int buy_price = prices[i];
            //        int sell_price = prices[j];
            //        max_profit = Math.Max(max_profit,(sell_price - buy_price) - fee);
            //    }
            //}
            //return max_profit;

            //int n = prices.Length;
            //if (n == 0) return 0;

            int cash = 0; // Profit if we do not own any stock
            //int hold = -prices[0]; //Profit if we own one stock

            //for (int i = 1; i < n; i++)
            //{
            //    cash = Math.Max(cash, hold + prices[i] - fee); // Max profit of selling the stock
            //    hold = Math.Max(hold, cash - prices[i]); //Max profit of buying the stock
            //}

            int _n = prices.Length;
            int[] buy = new int[_n];
            int[] sell = new int[_n];

            buy[0] = -prices[0];

            for (int i = 1; i < _n; i++)
            {
                buy[i] = Math.Max(buy[i - 1], sell[i - 1] - prices[i]);
                sell[i] = Math.Max(sell[i - 1], buy[i - 1] + prices[i] - fee);
            }
            
            return sell[_n - 1];
        }
    }
}
