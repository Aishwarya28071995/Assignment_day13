using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Maximum
    {
       
          
        public int ReturnMaxNumber(int num1,int num2,int num3)

        {
            int temp;
            if(num1.CompareTo(num2)>0 && num1.CompareTo(num3)>0)
            {

                temp = num3;
                num3 = num1;
                num1 = temp;

                return num2;
            }

            else if(num2.CompareTo(num1)>0 && num2.CompareTo(num3)>0)
            {
                temp = num3;
                num3 = num1;
                num1 = temp;
            }


          else
            {
                
                return num3;
            }
        }

        
    }
}
