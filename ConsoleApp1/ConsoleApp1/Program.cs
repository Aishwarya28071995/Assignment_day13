using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 112, 314, 432, 555, 678 };
            GenericMaximum<int> generic = new GenericMaximum<int>(array);
            generic.PrintMaxValue();

        }
    }
}
