
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

            NumberProblem np = new NumberProblem()
            {
                NumList = new List<int>() { 10, 20, 30, 4, -1, 2, 100, 7 }
            };


            List<int> ans = np.GetMaxGetMin();
            Console.WriteLine(ans[0]);
            Console.WriteLine(ans[1]);

        }


        // You can define other methods, fields, classes and namespaces here

        public class NumberProblem
        {
            public List<int> NumList { get; set; }

            public NumberProblem()
            {
                NumList = new List<int>();
            }

            public List<int> GetMaxGetMin()
            {
                int getmax;
                int getmin;
                List<int> result = new List<int>();
                getmax = NumList[0];
                getmin = NumList[0];

                for (int i = 0; i < NumList.Count; i++)
                {
                    if (NumList[i] > getmax)
                    {
                        getmax = NumList[i];
                    }


                    if (NumList[i] < getmin)
                    {
                        getmin = NumList[i];
                    }
                }

                result.Add(getmax);
                result.Add(getmin);

                return result;




            }


        }
    }
}