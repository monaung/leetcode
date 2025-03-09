using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code.Recursive
{
    public class Recursives
    {
        public static int Factorial(int n)
        {

            if (n <= 1)
            {
                return 1; // Base case: factorial of 0 or 1 is 1
            }
            else
            {
                return n * Factorial(n - 1); // Recursive case
            }

            Console.WriteLine(n);
        }


        public static void helper(int index, char[] str)
        {
            if (str == null || index >= str.Length)
            {
                return;
            }
            Console.WriteLine("before " + str[index]);
            helper(index + 1, str);
            Console.WriteLine("after " + str[index]);
        }
    }
}
