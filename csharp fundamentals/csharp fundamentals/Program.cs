
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
                Student x = new Student()
                {
                    Name = "Sam",
                    Age = 23,

                };

                Console.WriteLine("Name of the Student is " + x.Name);
                Console.WriteLine("Age of the Student is " + x.Age);


            }
        }

// You can define other methods, fields, classes and namespaces here

public class Student

        {

            public string Name { get; set; }
            public int Age { get; set; }

        }
    }
}