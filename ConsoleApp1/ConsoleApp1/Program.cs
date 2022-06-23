using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];
            array[0] = 30;
            array[1] = 40;
            array[2] = 50;

            MaxNumber maxNumber = new MaxNumber();
            int maximum = maxNumber.ReturnMaxNumber(array);
            Console.WriteLine("maximum number is " + maximum);


        }
    }
}
