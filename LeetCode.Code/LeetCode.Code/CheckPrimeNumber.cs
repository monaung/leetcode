using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class CheckPrimeNumber
    {
        public bool IsPrimeNumber(int number)
        {
            for (int i = 2; i <= number; i++)
            {
                if (i != number && number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
