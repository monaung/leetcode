using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    //1672. Richest Customer Wealth
    public class MaximumWealth
    {
        public MaximumWealth()
        {
            
        }
        public int MaximumWealthSolution(int[][] accounts)
        {
           
            int maxWealth = 0;

            //int[] result = new int[accounts.GetLength(0)];
            //for (int i = 0; i< accounts.Length; i++)
            //{
            //    result[i] = accounts[i][0];
            //    for (int j = 1; j < accounts[i].Length; j++)
            //    {
            //        result[i] = result[i] + accounts[i][j];
            //    }

            //    maxWealth = maxWealth < result[i] ? result[i]: maxWealth; 
            //}

            foreach (int[] customers in accounts)
            {
                int currentCustomerWealth = 0;

                foreach (int bank in customers)
                { 
                    currentCustomerWealth += bank;
                }

                maxWealth = Math.Max(maxWealth, currentCustomerWealth);
            }

            return maxWealth;
        }
    }
}
