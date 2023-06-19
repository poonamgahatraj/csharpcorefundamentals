
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
            List<List<int>> matrixA = new List<List<int>>();
            List<List<int>> matrixB = new List<List<int>>();
            List<int> row1 = new List<int> { 1, 2, 3 };
            List<int> row2 = new List<int> { 4, 5, 6 };
            List<int> row3 = new List<int> { 7, 8, 9 };
            matrixA.Add(row1);
            matrixA.Add(row2);
            matrixA.Add(row3);

            List<int> Row1 = new List<int> { 10, 20, 30 };
            List<int> Row2 = new List<int> { 40, 50, 60 };
            List<int> Row3 = new List<int> { 70, 80, 90 };
            matrixB.Add(Row1);
            matrixB.Add(Row2);
            matrixB.Add(Row3);


            for (int i = 0; i < matrixA.Count; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(matrixA[i][j]);
                Console.WriteLine();
            }
            Console.WriteLine();


            for (int i = 0; i < matrixB.Count; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(matrixB[i][j]);
                Console.WriteLine();
            }
            Console.WriteLine();


            for (int i = 0; i < 3; i++)
            {
                List<int> matrixC = new List<int>();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrixA[i][j] * matrixB[i][j]);
                    Console.WriteLine();
                    matrixC.Add(matrixA[i][j] * matrixB[i][j]);

                }
                Console.WriteLine();
            }

        }
    }
}