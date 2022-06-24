using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String num1 = "1.2";
            String num2 = "2.2";
            String num3 = "3.2";

            FindMaximum findMaximum = new FindMaximum();
            String max = findMaximum.maximum(num1, num2, num3);
            Console.WriteLine("Maximum number is " + max);
        }
    }
}
