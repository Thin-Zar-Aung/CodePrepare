/*
 * Given an array representing stock prices on different days, find the maximum profit from a single buy and sell.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Array
{
    internal class No18_StockPrice
    {
        public int getMaxProfit(int[] arr)
        {
            int buyPrice = arr[0];
            int maxProfit = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                buyPrice = Math.Min(buyPrice, arr[i]);
                int currProfit =  arr[i]-buyPrice;
                maxProfit = Math.Max(currProfit, maxProfit);

            }
            return maxProfit;
        }
    }
}
