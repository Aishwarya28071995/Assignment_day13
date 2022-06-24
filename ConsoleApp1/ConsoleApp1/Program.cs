using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 25;
            int num3 = 30;
            GenericMaximum<int> maximum = new GenericMaximum<int>(num1,num2,num3);
            int max = maximum.MaxMethod();
            Console.WriteLine(max);

        }
    }
}
