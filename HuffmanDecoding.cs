using System;
using System.Text;

namespace problem_solving
{
    class HuffmanDecoding
    {
        public static void ExecuteExample()
        {
            Console.WriteLine(Decode("101101", new string[] { "00", "10", "01", "11" }));
            Console.WriteLine(Decode("10111010", new string[] { "0", "111", "10" }));
            Console.WriteLine(Decode("0001001100100111001", new string[] { "1", "0" }));
            Console.WriteLine(Decode("111011011000100110", new string[] { "010", "00", "0110", "0111", "11", "100", "101" }));
            Console.WriteLine(Decode("001101100101100110111101011001011001010", new string[] { "110", "011", "10", "0011", "00011", "111", "00010", "0010", "010", "0000" }));
        }

        public static string Decode(string s, string[] dictionary)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length;)
            {
                for (int j = 0; j < dictionary.Length; j++)
                {
                    string code = dictionary[j];
                    if (s.Substring(i).StartsWith(code))
                    {
                        sb.Append((char)('A' + j));
                        i += code.Length;
                        break;
                    }
                }
            }

            return sb.ToString();
        }
    }
}
