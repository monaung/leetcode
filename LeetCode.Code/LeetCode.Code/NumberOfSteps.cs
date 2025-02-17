using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class NumberOfSteps
    {
        public int NumberOfStepsSolution(int num)
        {
            int step = 0;
            while (num != 0)
            {
                if ((num ^ 1) == (num + 1))
                {
                    num = num / 2;
                }
                else
                {
                    num = num - 1;
                }
                step++;
            }

            return step;
        }
    }
}
