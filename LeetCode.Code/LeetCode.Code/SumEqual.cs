using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class SumEqual
    {
        public bool IsSumEqual(int[] array, int sum)
        {
            bool isEqual = false;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == sum)
                    {
                        isEqual = true;
                        break;
                    }
                    { }
                }
            }
            return isEqual;
        }

        public bool HasPairWithSum(List<int> data, int sum)
        {
            HashSet<int> comp = new HashSet<int>(); //complements

            foreach (int value in data)
            {
                if (comp.Contains(value))
                    return true;
                comp.Add(sum - value);
            }

            return false;
        }
    }
}
