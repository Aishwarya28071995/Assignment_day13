using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
<<<<<<< HEAD
    internal class Maximum
    {
       
        public int FindMaximum(int num1,int num2,int num3)
=======
    internal class MaximumNumber
    {

        public int ReturnMaxNumber(int num1,int num2,int num3)
>>>>>>> T.C1.1_1
        {
            int temp;
            if(num1.CompareTo(num2)>0 && num1.CompareTo(num3)>0)
            {
<<<<<<< HEAD
                temp = num2;
                num2 = num1;
                num1 = temp;
=======
>>>>>>> T.C1.1_1
                return num2;
            }

            else if(num2.CompareTo(num1)>0 && num2.CompareTo(num3)>0)
            {
                return num2;
            }
<<<<<<< HEAD
=======

>>>>>>> T.C1.1_1
            else
            {
                temp = num1;
                num1 = num3;
                num3 = temp;
<<<<<<< HEAD
=======

>>>>>>> T.C1.1_1
                return num2;
            }
        }

        
    }
}
