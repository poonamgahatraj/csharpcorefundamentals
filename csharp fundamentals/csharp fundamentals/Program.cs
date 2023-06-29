
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
                int num;
                Console.WriteLine("enter the number");
                num = Convert.ToInt32(Console.ReadLine());

                for (int i = 2; i < num; i++)
                {
                    if (i % 2 != 0)

                    {
                        Console.WriteLine(i);
                    }

                }
            }


        }
    }
}

 