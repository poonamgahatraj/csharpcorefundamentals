
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
            List<int> a = new List<int>();
            a.Add(4);
            a.Add(5);
            List<List<int>> matrix = new List<List<int>>();
            List<int> row1 = new List<int>() { 1, 2, 3 };
            List<int> row2 = new List<int>() { 7, 12, 33 };
            List<int> row3 = new List<int>() { 17, 212, 33 };

            matrix.Add(row1);
            matrix.Add(row2);
            matrix.Add(row3);

            for (int i = 0; i < matrix.Count; i++)

            {

                for (i = 0; i < matrix.Count; i++)
                    Console.WriteLine(matrix[0][0]);
                Console.WriteLine(matrix[1][1]);
                Console.WriteLine(matrix[2][2]);
            }
        }

    
        












        }

    }
}
