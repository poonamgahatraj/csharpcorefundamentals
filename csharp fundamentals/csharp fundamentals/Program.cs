
using csharp_fundamentals.fundamentals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace csharp_fundamentals
{
    internal class Program
    {
        static void
         Main(string[] args)
        {
            {
                int lenght;
                Console.WriteLine("enter the length");
                lenght = Convert.ToInt32(Console.ReadLine());
                int breadth;
                Console.WriteLine("enter the breadth");
                breadth = Convert.ToInt32(Console.ReadLine());
                int c = Rectangle(lenght, breadth);

                Console.WriteLine("the area of rectangle is " + c);
            }

            // You can define other methods, fields, classes and namespaces here
            static int Rectangle(int a, int b)
            {

                int result;
                result = a * b;
                return result;
            }


        }
    }
}
 