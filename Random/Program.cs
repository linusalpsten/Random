using System;
using System.Diagnostics;

namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.Ticks);
            Console.WriteLine(Process.GetCurrentProcess().PrivateMemorySize64);
        }
    }
}
