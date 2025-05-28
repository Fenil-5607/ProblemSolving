using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_no.__2
{
    internal class PrintScheduler
    {

        public static void ExecuteExample() 
        {
            string[] threads = {"ABCDE"} ;
            string[] slices = { "0 20", "0 21" };

            string result = PrintScheduler.GetOutput(threads, slices);
            Console.WriteLine(result);

            Console.WriteLine($"Match : {result == "ABCDEABCDEABCDEABCDEABCDEABCDEABCDEABCDEA"}");
        }

        public static String GetOutput(String[] threads, String[] slices) 
        {
            string output = "";
            int[] positions = new int[threads.Length];

            for (int i = 0; i < threads.Length; i++)
            {
                positions[i] = 0;
            }

            foreach (string slice in slices)
            {
                string[] parts = slice.Split(' ');
                int threadIndex = int.Parse(parts[0]);
                int time = int.Parse(parts[1]);

                string currentThread = threads[threadIndex];

                for (int i = 0; i < time; i++)
                {
                    char c = currentThread[positions[threadIndex] % currentThread.Length];
                    output += Char.ToUpper(c);
                    positions[threadIndex]++;   
                }
            }

            return output.ToString();
        }
    }
} 


