using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace problem_no.__2
{
    internal class MovingAvg
    {

        public static void ExecuteExample()
        {
            double[] data = { 17,6.2,19,3.4};
            int k = 3;
            Console.WriteLine("this is the avg: " +Difference(k,data));
        }

        public static double Difference(int k, double[] data) 
        {
            if (data.Length < k) return 0.0;

            double max = double.MaxValue;
            double min = double.MinValue;
            double sum = 0;

            for (int i = 0; i < k; i++)
                sum += data[i];

            max = min = sum / k;

            for (int i = k; i < data.Length; i++) 
            {
                sum = sum - data[i-k] + data[i];
                double avg = sum / k;
                if (avg > max) max = avg;
                if(avg < min) min = avg;


            }
            return max - min;
        }
    }
}
