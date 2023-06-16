
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
            
           // int n;
           // List<int> numberList = new List<int>();
           
            
           // n = Convert.ToInt32(Console.ReadLine());
           
           //for(int i=0;i<n;i++)
           // {
               
           //     int number= Convert.ToInt32(Console.ReadLine());
           //     numberList.Add(number);
           // }
           
           //for(int i=0; i<numberList.Count;i++)
           // {
           //     Console.WriteLine(numberList[i]);
           // }

           //int sum = 0;
           //for(int i=0; i<numberList.Count; i++)
           // {
           //     sum = sum +numberList[i];
              
                    
           // }
            //Console.WriteLine( sum);

            //comparingtriplets

            int a_score = 0;
            int b_score = 0;
            List<int> ListA = new List<int> { 5, 6, 7 };
            List<int> ListB = new List<int> { 3, 6, 6};
            List<int> result = new List<int>();
            //result.Add(a_score);
           // result.Add(b_score);
           for(int i=0;i<3;i++)
            {
                if (ListA[i] > ListB[i])
                {
                    a_score++;
                }

                if (ListA[i] < ListB[i])
                {
                    b_score++;
                }
            }

            result.Add(a_score);
            result.Add(b_score);
            
            for(int i=0; i<2; i++)
            {
                Console.WriteLine(result[i]);
            }
            














        }

    }
}
