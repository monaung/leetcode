using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class CombinationOfPhoneNumber
    {
        //backtrack
        public IList<string> LetterCombinations(string digits)
        {
            List<string[]> digs = new List<string[]>();
            List<string> result = new List<string>();

            for (int i = 0; i < digits.Length; i++)
            {
                switch (digits[i])
                {
                    case '2':
                        digs.Add(new[] {"a","b","c"}); break;
                    case '3':
                        digs.Add(new[] {"d","e","f" }); break;
                    case '4':
                        digs.Add(new[] {"g","h","i"}); break;
                    case '5':
                        digs.Add(new[] {"j","k","l" }); break;
                    case '6':
                        digs.Add(new[] {"m","n","o" }); break;
                    case '7':
                        digs.Add(new[] { "p", "q", "r", "s" }); break;
                    case '8':
                        digs.Add(new[] { "t", "u","v"}); break;
                    case '9':
                        digs.Add(new[] { "w","x","y","z"}); break;
                    default:
                        break;
                }
            }

            if (digs.Count == 0) return result;

            if (digs.Count == 1)
            {
                for (int i = 0; i < digs[0].Length; i++)
                {
                    result.Add(digs[0][i]);
                }

                return result;
            }
            string[] initialStart = digs[0];

            for (int i = 0; i < initialStart.Length; i++)
            {
             
                for (int j = 1; j < digs.Count; j++)
                { 

                    for (int k = 0; k < digs[j].Length; k++)
                    {
                        result.Add(digs[0][i] + digs[j][k].ToString());                        
                    }
                }
            }

            return result;
        }
    }
}
