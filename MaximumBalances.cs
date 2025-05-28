using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_no.__2
{
    internal class MaximumBalances
    {
        public static void ExecuteExample()
        {
            string s = "))()()))(()";
            int result = solve(s);
            Console.WriteLine("MaximumBalance string : " + result);
        }

        public static int solve(string s) 
        {
            int left = 0, right = 0;

            foreach (char c in s)
            {
                if (c == '(') left++;
                else if (c == ')') right++;
            }

            int pairs = Math.Min(left, right);
            return pairs * (pairs + 1) / 2;
        }
    }
}
