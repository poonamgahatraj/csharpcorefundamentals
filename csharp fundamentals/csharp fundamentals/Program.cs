
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
                Student st1 = new Student();
                Student st2 = new Student();
                Student st3 = new Student();
                Student st4 = new Student();
                Student st5 = new Student();
                Student st6 = new Student();
                Student st7 = new Student();
                Student st8 = new Student();
                Student st9 = new Student();
                Student st10 = new Student();
                st1.Name = "Ram";
                st1.Id = 1;
                st2.Name = "Shyam";
                st2.Id = 2;
                st3.Name = "Sita";
                st3.Id = 3;
                st4.Name = "Gita";
                st4.Id = 4;
                st5.Name = "Ganga";
                st5.Id = 5;
                st6.Name = "Jamuna";
                st6.Id = 6;
                st7.Name = "Lucky";
                st7.Id = 7;
                st8.Name = "Revu";
                st8.Id = 8;
                st9.Name = "Ayesha";
                st9.Id = 9;
                st10.Name = "Babu";
                st10.Id = 10;

                List<Student> StudentList = new List<Student>();
                StudentList.Add(st1);
                StudentList.Add(st2);
                StudentList.Add(st3);
                StudentList.Add(st4);
                StudentList.Add(st5);
                StudentList.Add(st6);
                StudentList.Add(st7);
                StudentList.Add(st8);
                StudentList.Add(st9);
                StudentList.Add(st10);



                for (int i = 0; i < StudentList.Count; i++)
                {

                    if (StudentList[i].Id % 2 != 0)

                    {
                        Console.WriteLine(StudentList[i].Name);
                    }

                }

            }
        }

        // You can define other methods, fields, classes and namespaces here

        public class Student
        {
            public string Name;
            public int Id;

        }
    }
}