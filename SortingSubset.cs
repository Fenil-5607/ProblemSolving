using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace problem_no.__2
{
    internal class SortingSubset
    {
        public static void ExecuteExample()
        {
            int[] a = { 11, 11, 49, 7, 11, 11, 7, 7, 11, 49, 11 };

            int moves = getMinimalSize(a);
            Console.WriteLine("Minimal elements to move: " + moves);

            //Console.WriteLine("Sorted array:");
            //foreach (int num in a)
            //{
            //    //Console.Write(num + " ");
            //}
            //Console.WriteLine();


        }

        public static int getMinimalSize(int[] a)
        {
            int[] original = (int[])a.Clone();

            Array.Sort(a);


            int same = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == original[i])
                    same++;

                    Console.Write(a[i] + " ");

            }
            Console.WriteLine();

            return a.Length - same;
        }

    }
}
