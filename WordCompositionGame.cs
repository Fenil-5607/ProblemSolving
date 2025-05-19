using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving
{
    internal class WordCompositionGame
    {
        public static void ExecuteExample()
        {

            string[] ListA = { "bcdbb", "aaccd", "dacbc", "bcbda", "cdedc", "bbaaa", "aecae" };
            string[] ListB = { "bcdbb", "ddacb", "aaccd", "adcab", "edbee", "aecae", "bcbda" };
            string[] ListC = {"dcaab","aadbe","bbaaa","ebeec","eaecb","bcbba","aecae","adcab","bcbda"};

            string result = Score(ListA, ListB, ListC);
            Console.WriteLine("Final Score: " + result);
            Score(ListA, ListB, ListC);
        }

        public static string Score(string[] ListA, string[] ListB, string[] ListC) 
        {
            int ScoreA = 0, ScoreB = 0, ScoreC = 0;

            foreach (string word in ListA)
            {
                bool inB = Array.Exists(ListB, w => w == word);
                bool inC = Array.Exists(ListC, w => w == word);

                if (inB && inC) ScoreA += 1;
                else if (inB || inC) ScoreA += 2;
                else ScoreA += 3;

            }

            foreach (string word in ListB)
            {
                bool inA = Array.Exists(ListA, w => w == word);
                bool inC = Array.Exists(ListC, w => w == word);

                if (inA && inC) ScoreB += 1;
                else if (inA || inC) ScoreB += 2;
                else ScoreB += 3;

            }

            foreach (string word in ListC)
            {
                bool inA = Array.Exists(ListA, w => w == word);
                bool inB = Array.Exists(ListB, w => w == word);

                if (inA && inB) ScoreC += 1;
                else if (inA || inB) ScoreC += 2;
                else ScoreC += 3;

            }
            return $"{ScoreA}/{ScoreB}/{ScoreC}";
        }
    }
}
