using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving
{
    public class LexMaxReplace
    {

        public static void ExecuteExample()
        {
            string result = Get("abb", "c");
            Console.WriteLine(result);
        }

        public static string Get(string s, string t)
        {
            char[] sArr = s.ToCharArray();
            char[] tArr = t.OrderByDescending(c => c).ToArray();
            int j = 0;

            for (int i = 0; i < sArr.Length && j < tArr.Length; i++)
            {
                if (tArr[j] > sArr[i])
                {
                    sArr[i] = tArr[j];
                    j++;
                }
            }

            return new string(sArr);
        }
    }
}
