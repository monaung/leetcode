using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    //985
    public class SumOfEvenNumbersAfterQueries
    {
        public int[] SumOfEvenAfterQueries(int[] nums, int[][] queries)
        {
            int[] result = new int[nums.Length];


            for (int j = 0; j < queries.Length; j++)
            {
                int value = queries[j][0];
                int index = queries[j][1];

                //for (int k = 0; k < nums.Length; k++)
                //{
                //    nums[k] = k == index ? nums[k] + value : nums[k];
                //}
                nums[index] = nums[index] + value;

                int temp = 0;
                for (int l = 0; l < nums.Length; l++)
                {
                    temp += nums[l] % 2 == 0 ? nums[l] : 0;
                }

                result[j] = temp;
            }

            return result;

        }
    }
}
