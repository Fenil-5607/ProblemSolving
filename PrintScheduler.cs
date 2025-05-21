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
            string[] threads = { "AB", "CD" };
            string[] slices = { "0 1", "1 1", "0 1", "1 2" };

            string result = PrintScheduler.getOutput(threads, slices);
            Console.WriteLine(result);
        }

        public static String GetOutput(String[] threads, String[] slices) 
        {

        } 
    }
}
