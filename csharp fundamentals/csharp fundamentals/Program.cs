
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
                int side;
                Console.WriteLine("enter the side");
                side = Convert.ToInt32(Console.ReadLine());

                int z = Area(side);
                Console.WriteLine( "the area of square is " + z);


            }

            // You can define other methods, fields, classes and namespaces here

            static int Area(int side)
            {

                int result;
                result = 4 * side;

                return result;
            }

        }
    }

    }
 