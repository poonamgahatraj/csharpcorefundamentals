
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
                UserDetail x = UserInformation();

                Console.WriteLine(x);
            }

            // You can define other methods, fields, classes and namespaces here
            static UserDetail UserInformation()
            {
                string name;
                int age;
                string address;

                Console.WriteLine("enter user name");
                name = Console.ReadLine();
                Console.WriteLine("enter user age");
                age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter user address");
                address = Console.ReadLine();

                UserDetail user = new UserDetail();
                user.Name = name;
                user.Age = age;
                user.Address = address;

                return user;
            }
        }

        class UserDetail
        {
            public string Name;
            public int Age;
            public string Address;


        }

    }
}
 