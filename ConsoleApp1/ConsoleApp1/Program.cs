using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maximum max = new Maximum();
            int maxNumber = max.FindMaximum(10, 20, 30);
            Console.WriteLine("Maximum number is " + maxNumber);

        }
    }
}
