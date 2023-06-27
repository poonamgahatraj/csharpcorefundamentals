
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
            int a = Sum(new List<int>() { 2, 3, 4, 5 });
            int b = Square(new List<int>() { 2, 3, 4, 5 });

            Console.WriteLine("sum is :" + a);
            Console.WriteLine("square is :" + b);


            List<int> FinalList = new List<int>();
            FinalList.Add(a);
            FinalList.Add(b);

            for (int i = 0; i < FinalList.Count; i++)
            {
                Console.WriteLine(FinalList[i]);
            }

            List<int> p = Both(new List<int>() { 2, 3, 4, 5 });
            for (int i = 0; i < p.Count; i++)
            {
                Console.WriteLine(p[i]);
            }


            static int Sum(List<int> c)
            {
                int sum;
                sum = 0;

                List<int> num = new List<int> { 2, 3, 4, 5 };
                for (int i = 0; i < num.Count; i++)
                {

                    sum = num[i] + sum;

                }
                return sum;
            }
            static int Square(List<int> c)
            {
                int square;
                square = 0;

                List<int> num = new List<int> { 2, 3, 4, 5 };
                for (int i = 0; i < num.Count; i++)
                {

                    square = num[i] * num[i] + square;

                }
                return square;
            }

            static List<int> Both(List<int> d)

            {
                List<int> num = new List<int> { 2, 3, 4, 5 };
                List<int> Blank = new List<int>();
                int square = 0;
                int sum = 0;
                for (int i = 0; i < num.Count; i++)

                {
                    sum = num[i] + sum;
                    square = num[i] * num[i] + square;
                }
                Blank.Add(sum);
                Blank.Add(square);

                return Blank;
            }

        }
    }

    }
 