using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;

            MaxNumber maxNumber = new MaxNumber();
            int maximum = maxNumber.ReturnMaxNumber(num1, num2, num3);
            Console.WriteLine("maximum number is " + maximum);


        }
    }
}
