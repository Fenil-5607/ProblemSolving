using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_no.__2
{
    internal class Mailbox
    {
        public static void ExecuteExample() 
        {
            string collection = "ABCDEFGHIJKLMNOPRSTUVWXYZ1234567890";
            string[] addresses = { "2 FIRST ST", " 31 QUINCE ST", "606 BAKER" };

            int result = Impossible(collection, addresses);
            Console.WriteLine("addresses not in form : " +result); 

        }

        public static int Impossible(string collection, string[] addresses)
        {
            int impossibleCount = 0;

            Dictionary<char, int> countLetter = new Dictionary<char, int>();

            foreach (char c in collection.ToUpper())
            {
                if (!countLetter.ContainsKey(c))
                    countLetter[c] = 0;
                countLetter[c]++;
            }

            foreach (string checkAddress in addresses)
            {
                Dictionary<char, int> availableCharCount = new Dictionary<char, int>(countLetter);
                bool canForm = true;

                foreach (char c in checkAddress.ToUpper())
                {
                    if (c == ' ') continue;
                       

                    if (!availableCharCount.ContainsKey(c) || availableCharCount[c] == 0)
                    {
                        canForm = false;
                        break;
                    }
                    else
                    {
                        availableCharCount[c]--;
                    }
                }

                if (!canForm)
                    impossibleCount++;
            }

            return impossibleCount;
        }
    }
}

