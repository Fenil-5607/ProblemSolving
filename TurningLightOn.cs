using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace problem_no.__2
{
    internal class TurningLightOn
    {

        public static void ExecuteExample() 
        {
            String[] board = {"0101",
                              "1010",
                              "0101",
                              "1010"};
            int result = minFlips(board);
            Console.WriteLine("Minimum flips required to turn all lights on : " + result);
        }

        public static int minFlips(String[] board) 
        {
            int R = board.Length, C = board[0].Length, flips = 0;
            char[][] bulbs = Array.ConvertAll(board, row => row.ToCharArray());

            for (int i = R - 1; i >= 0; i--)
            {     
                for (int j = C - 1; j >= 0; j--)
                {
                    if (bulbs[i][j] == '0')
                    {
                        flips++;

                        for (int x = 0; x <= i; x++)
                        {
                            for (int y = 0; y <= j; y++)
                            {
                                if (bulbs[x][y] == '0')
                                {
                                    bulbs[x][y] = '1';
                                }
                                else
                                {
                                    bulbs[x][y] = '0';
                                }

                            }
                        }
                    }
                }
            }

            return flips;
        }
    }
}

