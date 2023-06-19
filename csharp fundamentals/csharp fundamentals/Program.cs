
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
            List<List<int>> matrix = new List<List<int>>();
            List<int> row1 = new List<int> { 1, 2, 3 };
            List<int> row2 = new List<int> { 4, 5, 6 };
            List<int> row3 = new List<int> { 7, 8, 9 };

            matrix.Add(row1);
            matrix.Add(row2);
            matrix.Add(row3);

            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < 3; j++)

                    Console.Write(matrix[i][j]);
                Console.WriteLine();

            }
            Console.WriteLine();


            List<int> LeftDiagonal = new List<int>();
            for (int i = 0; i <= 0; i++)
            {
                Console.WriteLine(matrix[0][0]);
                Console.WriteLine(matrix[1][1]);
                Console.WriteLine(matrix[2][2]);
            }
            LeftDiagonal.Add(matrix[0][0]);
            LeftDiagonal.Add(matrix[1][1]);
            LeftDiagonal.Add(matrix[2][2]);

            Console.WriteLine();


            List<int> RightDiagonal = new List<int>();
            for (int i = 0; i <= 0; i++)
            {
                Console.WriteLine(matrix[0][2]);
                Console.WriteLine(matrix[1][1]);
                Console.WriteLine(matrix[2][0]);
            }
            RightDiagonal.Add(matrix[0][2]);
            RightDiagonal.Add(matrix[1][1]);
            RightDiagonal.Add(matrix[2][0]);

            Console.WriteLine();


            int sum1 = 0;
            for (int i = 0; i < 3; i++)
            {
                sum1 = LeftDiagonal[i] + sum1;
            }
            Console.WriteLine(sum1);
            Console.WriteLine();


            int sum2 = 0;
            for (int i = 0; i < 3; i++)
            {
                sum2 = RightDiagonal[i] + sum2;
            }
            Console.WriteLine(sum2);
            Console.WriteLine();

            int sub = 0;
            {
                sub = sum1 - sum2;
                Console.WriteLine(sub);
            }
        }
    }
}
