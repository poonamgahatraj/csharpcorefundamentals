using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_fundamentals.fundamentals
{
    public class ConditionalProblem
    {
        public void ReadUserName()
        {
            string name;
            Console.WriteLine("enter your name");
            name = Console.ReadLine();
            Console.WriteLine("your name is " + name);
        }

        public void CheckEvenOdd()
        {
            int x;
            Console.WriteLine("enter a number");
            x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("it is an even number");
            }
            else
            {
                Console.WriteLine("it is a odd number");
            }
        }
        public void StudentReport()
        {
            string name;
            Console.WriteLine("enter your name");
            name = Console.ReadLine();

            int x;
            Console.WriteLine("enter your class");
            x = int.Parse(Console.ReadLine());

            int y;
            Console.WriteLine("enter your age");
            y = int.Parse(Console.ReadLine());

            int z;
            Console.WriteLine("enter your monthly fees");
            z = int.Parse(Console.ReadLine());

            float a;
            Console.WriteLine("enter your height");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("***STUDENT PROFILE***");
            Console.WriteLine("your name is" + name);
            Console.WriteLine("your class is" + x);
            Console.WriteLine("your age is" + y);
            Console.WriteLine("your monthly fees is" + z);
            Console.WriteLine("your height is" + a);
            Console.WriteLine("your annual fees is" + z * 12);









        }


        public void PrimeNumber()
        {
            int i;
            int x;
            bool isprime = true;
            Console.WriteLine("enter a number");
            x = int.Parse(Console.ReadLine());

            for (i = 2; i < x; i++)
                if (x % i == 0)
                {
                    Console.WriteLine("it is not a prime number");
                    isprime = false;


                }
            if (isprime == true)
            {
                Console.WriteLine("it is prime number");

            }


        }




        public void VowelLetters()
        {
            int i;
            bool hasvowel = true;
            string name;
            Console.WriteLine("Enter user name");
            name = Console.ReadLine();
            

            for ( i = 0; i <= name.Length; i++)
            {
                if (
                   (name[i] == 'a')
                || (name[i] == 'e')
                || (name[i] == 'i')
                || (name[i] == 'o')
                || (name[i] == 'u')
                )
                { 
                    hasvowel = false;
                    Console.WriteLine("name do not have vowel");
                    
            
                }
            if (hasvowel==true)
                {
                    Console.WriteLine( " name  have vowel ");
                    break;
                }


            }
        }
    }
}



