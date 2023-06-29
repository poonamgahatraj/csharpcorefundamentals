
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

                Student suraj = new Student();
                suraj.Name = "suraj gahatraj";
                suraj.Age = 20;
                ShowInfo(suraj);

            }




            static void ShowInfo(Student st)
            {
                Console.WriteLine("Name is " + st.Name);
                Console.WriteLine("Age is " + st.Age);


            }
        }

        // You can define other methods, fields, classes and namespaces here

        class Student
        {
            public string Name;
            public int Age;

        }

    }
}

 