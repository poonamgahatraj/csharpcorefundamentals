using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;


namespace csharp_fundamentals.fundamentals
{
    public class FunctionProblem
    //function with arguments and return value.
    {
        public int FindMax(int num1, int num2)
        {
            int result;
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;
        }

        public int Output(int num1, int num2, int num3, int num4, int num5)
        {
            int result = 0;
            int i;
            for (i = 0; i < 6; i++)
            {
                result += (i);



            }
            return result;

        }

        
     



    }
}

