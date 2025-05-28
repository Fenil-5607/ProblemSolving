using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_no.__2
{
    internal class PalindromeDecoding
    {
        public static void ExecuteExampl() 
        {
            string code = "Misip";
            int[] position = { 2, 3, 1, 7 };
            int[] length = { 1, 1, 2, 2 };

            string result = decode(code, position, length);
            Console.WriteLine("PalindromeDecoding : " + result);
            
        }

        public static string decode(String code, int[] position, int[] length) 
        {
            for (int i = 0; i < position.Length; i++)
            {
                int pos = position[i];
                int len = length[i];    

                string substring = code.Substring(pos, len);

                char[] reversed = substring.ToCharArray();
                Array.Reverse(reversed);
                string reversedStr = new string(reversed);

                string before = code.Substring(0, pos + len);
                string after = code.Substring(pos + len);
                
                code = before + reversedStr + after;

            }
            return code;
        }
    }
}
