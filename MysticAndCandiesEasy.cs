using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_no.__2
{
    internal class MysticAndCandiesEasy
    {
        public static void ExecuteExample() 
        {
            int c = 10;
            int x = 7;
            int[] high = { 3, 3, 3, 3, 3 };

            int result = minBoxes(c,x,high);
            Console.WriteLine("smallest number of boxes mystic_tc may choose : " + result);  
        }

        public static int minBoxes(int C, int X, int[] high)
        {
            int totalSum = high.Sum();  
            Array.Sort(high);
            Array.Reverse(high); 

            int MovingIndexSum = 0;

            for (int i = 0; i < high.Length; i++)
            {
                MovingIndexSum += high[i];
                int RemainingValue = totalSum - MovingIndexSum;

                if (C - RemainingValue >= X)
                    return i + 1;
            }

            return high.Length;
        }

    }
}
