using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class RansomNote
    {

        //383. Ransom Note
        public bool RansomNoteSolution(string ransomNote, string magazine)
        {
            Dictionary<char, int> magazineLetters = new Dictionary<char, int>();
            for (int i = 0; i < magazine.Length; i++)
            {
                int currentCount = magazineLetters.GetValueOrDefault(magazine[i], 0);
                magazineLetters[magazine[i]] = currentCount + 1;
            }

            for (int j = 0; j < ransomNote.Length; j++)
            {
                int currentCount = magazineLetters.GetValueOrDefault(ransomNote[j], 0);
                if (currentCount == 0)
                    return false;

                magazineLetters[ransomNote[j]] = currentCount - 1;
            }

            return true;
        }
    }
}
