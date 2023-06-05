using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_fundamentals.fundamentals
{
    public class LoopProblem
    {
        public void WhileLoop()
        {
            int a = 1;
            while (a<=10) 
            {
                Console.WriteLine(a);
                a++;
            }
            
        }

        public void ForLoop()
        {
            for (int i = 1; i <= 10; i++)
            {
              
                Console.WriteLine(i);
            }

        }

       public void MultiplesOfThree()
        {
            int a = 1;
            int factor = 3;
            while(a<=10)
            {

                int result = 3 * a;
                Console.WriteLine(3+"  X " +a+"  = "+result);
                //Console.WriteLine(3 * a);
                a++;
            }
        
        
        }
        public void UserInputWhileLoop()
        {
            int a;
            a = int.Parse(Console.ReadLine());
            while(a<=10) 
            {
                int result = 4 * a;
                Console.WriteLine(4 + "*" + a + "=" + result);
                a++;
            
            
            }
               }
        public void IncrementInFour()
        {
            int a = 1;
            while (a<=10)
            {
                int result = 4 + a;
                Console.WriteLine(4+"+"+a+"="+ result);
                a++;



            }
        }

            

    }


}



