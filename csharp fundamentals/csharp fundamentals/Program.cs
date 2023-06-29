
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
                PeopleInformation x = Survey();
                Console.WriteLine(x);

            }

            // You can define other methods, fields, classes and namespaces here

            static PeopleInformation Survey()
            {
                string name;
                int age;
                string occupation;
                Console.WriteLine("Enter person name");
                name = Console.ReadLine();
                Console.WriteLine("Enter person age");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter person occupation");
                occupation = Console.ReadLine();
                PeopleInformation pi = new PeopleInformation();
                pi.Name = name;
                pi.Age = age;
                pi.Occupation = occupation;

                return pi;
            }
        }

            class PeopleInformation
        {
            public string Name;
            public int Age;
            public string Occupation;

        }



    }
}

 