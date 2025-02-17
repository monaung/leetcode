using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class RunningSum
    {
        //1480. Running Sum of 1d Array
        public int[] RunningSumSolution(int[] nums)
        {
            //int[] result = new int[nums.Length] ;

            //result[0] = nums[0];

            //for (int i = 1; i < nums.Length; i++)
            //{
            //    result[i] = result[i-1] + nums[i];
            //}

            //return result;

            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i - 1] + nums[i];
            }
            return nums;
        }
    }
}
