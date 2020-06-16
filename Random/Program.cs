using System;
using System.Diagnostics;
using System.IO;

namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
            string numsX = "";
            string numsY = "";
            string numsZ = "";
            for (int i = 0; i < 10000; i++)
            {
                numsX += Chaos(ThreeLastDigits(DateTime.Now.Ticks) / 1000.0) + " ";
                numsY += Chaos(ThreeLastDigits(DateTime.Now.Ticks) / 1000.0) + " ";
                numsZ += Chaos(ThreeLastDigits(DateTime.Now.Ticks) / 1000.0) + " ";
            }
            string path = @"C:\Users\jagme\source\repos\Random\Random\nums.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(numsX);
                sw.WriteLine(numsY);
                sw.WriteLine(numsZ);
            }
        }

        static int ThreeLastDigits(long num)
        {
           return Convert.ToInt32(num % 1000);
        }

        static double Chaos(double x)
        {
            return Math.Sin((1 / (x / 100)) * (1 / (1 - x)));
        }
    }
}
