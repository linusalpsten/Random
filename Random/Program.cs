using System;
using System.Diagnostics;
using System.IO;

namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ThreeLastDigits(DateTime.Now.Ticks));
            string numsX = "";
            string numsY = "";
            string numsZ = "";
            for (int i = 0; i < 10000; i++)
            {
                numsX += ThreeLastDigits(DateTime.Now.Ticks) + " ";
                numsY += ThreeLastDigits(DateTime.Now.Ticks) + " ";
                numsZ += ThreeLastDigits(DateTime.Now.Ticks) + " ";
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
    }
}
