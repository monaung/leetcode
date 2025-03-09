using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class ContainCommonItem
    {
        public bool Solution(int[] array1, int[] array2) 
        {
            HashSet<int> hashtable = new HashSet<int>();

            for (int i = 0; i < array1.Length; i++) {
                hashtable.Add(array1[i]);
            }

            return false;
        }
    }
}
