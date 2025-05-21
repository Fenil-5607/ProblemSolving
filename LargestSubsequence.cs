using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_no.__2
{
    internal class LargestSubsequence
    {

        public static void ExecuteExample() 
        {
            string result = GetLargest("test");
            Console.WriteLine(result);
        }
        public static string GetLargest(string s) 
        {
            string result = "";
            char maxChar = (char)0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] >= maxChar)
                {
                    result = s[i] + result;
                    maxChar = s[i];
                }
            }

            return result;
        }
    }
}
