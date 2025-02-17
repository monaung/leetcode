using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class FizzBuzz
    {
        public IList<string> FizzBuzzSolution(int n)
        {
            string[] temp = new string[n];

            for (int i = 1; i <= n; i++)
            {
                
                temp[i - 1] = i % 3 == 0 ? "Fizz" : string.Empty;
                temp[i - 1] = i % 5 == 0 ? temp[i - 1] + "Buzz" : temp[i - 1];

                if(string.IsNullOrEmpty(temp[i - 1]))
                    temp[i - 1] = i.ToString();
            }
            return temp.ToList<string>() ;
        }
    }
}
