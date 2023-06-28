
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
                string a = UserDetail();
                int b = UserDetail1();
                Console.WriteLine("the user detail is :");
                Console.WriteLine("the user name is " + a);
                Console.WriteLine("the user age is " + b);

            }

            // You can define other methods, fields, classes and namespaces here

             static string UserDetail()
            {
                string name;
                Console.WriteLine("enter the user name");
                name = Console.ReadLine();
                return name;

            }

             static int UserDetail1()
            {

                int age;
                Console.WriteLine("enter the user age");
                age = Convert.ToInt32(Console.ReadLine());

                return age;
            }


        }
    }

    }
 