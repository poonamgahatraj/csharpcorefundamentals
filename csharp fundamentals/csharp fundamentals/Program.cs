
using csharp_fundamentals.fundamentals;
using System;
using System.ComponentModel;

namespace csharp_fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            ConditionalProblem cp = new ConditionalProblem();
            // cp.ReadUserName();

            // cp.CheckEvenOdd();

            // cp.StudentReport();
          //  LoopProblem lp = new LoopProblem();
            //   lp.WhileLoop();

            //lp.ForLoop();
            //  lp.MultiplesOfThree();
            // lp.UserInputWhileLoop();
            // lp.IncrementInFour();
            // lp.SumOfNaturalNumber();
            // lp.CubeofNaturalNumbers();
            //lp.NestedIfLoop(); 
            // lp.IfLoop();
            //lp.ArraysAndList();
            // lp.Array();
            //lp.marks();
            //lp.SumOfAllElement();
            // lp.Integers();
            // lp.Data();
            // lp.UserInput();
            // lp.EvenOdd();
            //lp.DivisibleByBoth();
            //lp.ReverseOrder();
            // lp.SumOfAllElement();
            FunctionProblem fp = new FunctionProblem();
           //int max=fp.FindMax(5,7);
           // Console.WriteLine(max);

            //int output = fp.Output(1,2,3,4,5);
            //Console.WriteLine(output);
            //int sum = fp.sum();
            //Console.WriteLine(sum);
            
            int sum=fp.sum();
            Console.WriteLine(sum);

        }
    
    }
}
