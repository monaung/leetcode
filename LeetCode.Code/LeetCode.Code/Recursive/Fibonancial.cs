using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code.Recursive.Recursive
{
    public class Fibonancial
    {
        public void Fib()
        {
            //int total = 0;

            //for (int i = 5; i >=1; i--)
            //{
            //    int int1 = FibInt(i - 1);
            //    int int2 = FibInt(i - 2);
            //    total += int1 + int2;
            //}
            int result = FibInt(5);

        }
        public int FibInt(int value)
        {
            if (value == 1 || value == 2) return 1;

            int result = 0;
            result += FibInt(value - 1);

            return result;
        }
    }
}
