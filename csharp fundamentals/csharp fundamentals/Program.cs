
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
                {
                    int num;
                    bool isPrime = true;
                    Console.WriteLine("enter the num");
                    num = Convert.ToInt32(Console.ReadLine());
                    for (int i = 2; i < num; i++)
                    {
                        for (int j = 2; j < num; j++)
                        {

                            if (i != j && i % j == 0)
                            {
                                isPrime = false;
                                break;
                            }

                        }
                        if (isPrime)
                        {
                            Console.Write(i);
                        }
                        isPrime = true;

                    }
                }
            }
        }
    }
}