﻿using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            string numsX = "";
            string numsY = "";
            string numsZ = "";
            double sumX = 0;
            double sumY = 0;
            double sumZ = 0;
            for (int i = 0; i < n; i++)
            {
                int x = GetNum();
                numsX += x + " ";
                sumX += x;
                Thread.Sleep(x%3);
                int y = GetNum();
                numsY += y + " ";
                sumY += y;
                Thread.Sleep(y%3);
                int z = GetNum();
                numsZ += z + " ";
                sumZ += z;
                Thread.Sleep(z%3);
            }
            string path = @"C:\Users\jagme\source\repos\Random\Random\nums.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(numsX);
                sw.WriteLine(numsY);
                sw.WriteLine(numsZ);
            }
            Console.WriteLine(sumX/n);
            Console.WriteLine(sumY/n);
            Console.WriteLine(sumZ/n);
        }

        static int ThreeLastDigits(long num)
        {
           return Convert.ToInt32(num % 1000);
        }

        static double Chaos(double x)
        {
            return Math.Sin((1 / (x / 100)) * (1 / (1 - x)));
        }
        static int GetNum()
        {
            return ThreeLastDigits(DateTime.Now.Ticks);
        }
    }
}
