using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Maximum max = new Maximum();
            int maxNumber = max.FindMaximum(10, 20, 30);
            Console.WriteLine("Maximum number is " + maxNumber);
=======
            int num1 = 10;
            int num2 = 20;
            int num3 = 30;
            MaximumNumber max = new MaximumNumber();
            int maxNumber = max.ReturnMaxNumber(num1, num2, num3);
            Console.WriteLine("max number is " + maxNumber);

>>>>>>> T.C1.1_1

        }
    }
}
