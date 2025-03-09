using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code.Recursive.Recursive
{
    public class Factorial
    {
        public int FindFactorialIterative(int number)
        {
            int total = 1;

            for (int i = number; i != 1; i--)
            {
                total = i * total;
            }

            return total;
        }

        public int FindFactorialRecursive(int number)
        {
            if (number == 1)
                return 1;

            return FindFactorialRecursive(number - 1) * number;

            //0 FindFactorialRecursive(3) => 6
            //1. FindFactorialRecursive(2) => 2 * 3
            //2. FindFactorialRecursive(1) => 1 * 2


            //0. FindFactorialRecursive(5) => 24 * 5 => 120
            //1. FindFactorialRecursive(4) => 6 * 4
            //2. FindFactorialRecursive(3) => 2 * 3
            //3. FindFactorialRecursive(2) => 1 * 2
            //4. FindFactorialRecursive(1) => 1
        }
    }
}
