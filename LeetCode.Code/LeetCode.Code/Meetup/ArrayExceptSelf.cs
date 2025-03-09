using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code.Meetup
{
    public class ArrayExceptSelf
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] answer = new int[n];

            // Step 1: Fill the answer array with prefix products
            answer[0] = 1;
            for (int i = 1; i < n; i++)
            {
                answer[i] = nums[i - 1] * answer[i - 1];
            }

            // Step 2: Traverse the array from the right to compute suffix products
            int suffixProduct = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                answer[i] *= suffixProduct;
                suffixProduct *= nums[i];
            }

            return answer;

            //int[] answers = new int[nums.Length];

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int x = 1;
            //    for (int j = 0; j < nums.Length; j++)
            //    {
            //        x *= j == i ? 1 :  nums[j];
            //    }
            //    answers[i] = x;
            //}

            //return answers;
        }
    }
}
