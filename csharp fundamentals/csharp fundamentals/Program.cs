
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
                Student st = new Student();
                Student st1 = new Student();
                Student st2 = new Student();
                Student st3 = new Student();
                Student st4 = new Student();

                st.firstname = "alex";
                st.lastname = "hdfd";
                st1.firstname = "john";
                st1.lastname = "hegks";
                st2.firstname = "sam";
                st2.lastname = "jhdcjsh";
                st3.firstname = "rachel";
                st3.lastname = "jsshl";
                st4.firstname = "joy";
                st4.lastname = "dhdj";


                List<Student> StudentList = new List<Student>();
                StudentList.Add(st);
                StudentList.Add(st1);
                StudentList.Add(st2);
                StudentList.Add(st3);
                StudentList.Add(st4);



                for (int i = 0; i < StudentList.Count; i++)
                {
                    Console.WriteLine(StudentList[i].firstname);
                }
            }
        }

// You can define other methods, fields, classes and namespaces here
public class Student
        {
            public string firstname;
            public string lastname;
        }

    }
}
    
