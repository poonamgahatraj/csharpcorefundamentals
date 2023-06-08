using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace csharp_fundamentals.fundamentals
{
    public class LoopProblem
    {
        public void WhileLoop()
        {
            int a = 1;
            while (a <= 10)
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
            while (a <= 10)
            {

                int result = 3 * a;
                Console.WriteLine(3 + "  X " + a + "  = " + result);
                //Console.WriteLine(3 * a);
                a++;
            }


        }
        public void UserInputWhileLoop()
        {
            int a;
            a = int.Parse(Console.ReadLine());
            while (a <= 10)
            {
                int result = 4 * a;
                Console.WriteLine(4 + "*" + a + "=" + result);
                a++;


            }
        }
        public void IncrementInFour()
        {
            int a = 1;
            while (a <= 10)
            {
                int result = 4 + a;
                Console.WriteLine(4 + "+" + a + "=" + result);
                a++;



            }
        }

        public void SumOfNaturalNumber()
        {
            int sum = 0;
            for (int a = 1; a <= 10; a++)
            {
                sum += a;

            }
            Console.WriteLine("the sum of first 10 natural numbers is " + sum);
        }



        public void CubeofNaturalNumbers()
        {
            int cube = 1;
            for (int a = 1; a <= 1; a++)

            {
                cube += a * 3;

            }

            Console.WriteLine("the cube of 10 natural numbers is " + cube);

        }






        public void NestedIfLoop()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(i);

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                    ;

                }
                Console.WriteLine();
                Console.WriteLine();

            }

        }
        public void IfLoop()
        {
            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j <= i; j++)

                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }

        }
        public void ArraysAndList()
        {
            List<string> icecream = new List<string>();

            icecream.Add("vanilla");
            icecream.Add("strawberry");
            icecream.Add("chocolate");

            for (int i = 0; i < icecream.Count; i++)
            {
                Console.WriteLine(icecream[i]);
            }



            {

            }
        }


        public void Array()
        {
            string[] color = { "red", "green", "blue" };
            {
               // Console.WriteLine(color[0]);
                for (int i = 0; i < color.Length; i++)
                {
                    Console.WriteLine(color[i]);
                }
            }

        }

    }



}


      

    



