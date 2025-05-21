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
            string result = Get("xldyzmsrrwzwaofkcxwehgvtrsximxgdqrhjthkgfucrjdvwlr", "xfpidmmilhdfzypbguentqcojivertdhshstkcysydgcwuwhlk" );
            Console.WriteLine(result);
        }

        public static string Get(string s, string t)
        {
            char[] sArray = s.ToCharArray();
            char[] tArray = t.OrderByDescending(c => c).ToArray();
            int j = 0;

            for (int i = 0; i < sArray.Length && j < tArray.Length; i++)
            {
                if (tArray[j] > sArray[i])
                {
                    sArray[i] = tArray[j];
                    j++;
                }
            }

            return new string(sArray);
        }
    }
}
