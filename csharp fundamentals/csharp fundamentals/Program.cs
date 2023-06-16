
using csharp_fundamentals.fundamentals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace csharp_fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string a_name="adam";
            //string j_name="john";
            //int a_age = 20; ;
            //int a_total_subject=5;
            //int a_total_marks = 400;

            //int j_age = 21; ;
            //int j_total_subject = 5;
            //int j_total_marks = 300;


            //Console.WriteLine("Detail of adama are");
            //Console.Write("Name is " + a_name);
            //Console.WriteLine("Age is " + a_age);
            //Console.WriteLine("Total marks is" + a_total_marks);
            //Console.WriteLine("aVERAGE IS "+(a_total_marks/a_total_subject));




            //Console.WriteLine("Detail of John are");
            //Console.Write("Name is " + j_name);
            //Console.WriteLine("Age is " + j_age);
            //Console.WriteLine("Total marks is" + j_total_marks);
            //Console.WriteLine("aVERAGE IS " + (j_total_marks / j_total_subject));


            //StudentRecordSystem adam=new StudentRecordSystem();
            //adam.Age = "29";
            //adam.Name = "Adam";
            //adam.TotalMarks = 300;
            //adam.TotalSubject = 5;



            //int adam_average=adam.TotalMarks/adam.TotalSubject;




            //StudentRecordSystem sam = new StudentRecordSystem();
            //sam.Age = "29";
            //sam.Name = "Adam";
            //sam.TotalMarks = 300;
            //sam.TotalSubject = 5;
            //sam.ShowAverage();

            //int sam_average = sam.TotalMarks / sam.TotalSubject;












            // Console.WriteLine("Hello World!");
            //ConditionalProblem cp = new ConditionalProblem();
            // cp.ReadUserName();

            // cp.CheckEvenOdd();

            // cp.StudentReport();
            // cp.PrimeNumber();
            //cp.VowelLetters();
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
            // // lp.SumOfAllElement();
            // FunctionProblem fp = new FunctionProblem();
            ////int max=fp.FindMax(5,7);
            //// Console.WriteLine(max);

            // //int output = fp.Output(1,2,3,4,5);
            // //Console.WriteLine(output);
            // //int sum = fp.sum();
            // //Console.WriteLine(sum);

            // //int sum=fp.sum();
            // //Console.WriteLine(sum);
            // StudentRecord Data= new StudentRecord();
            // Data.Average("Adam", 12, 8, 480);


            // Console.WriteLine("Average marks of Adam is"   +  Data.Average ("Adam", 12, 8, 480));

            //swaping value
            int a = 10;
            int b = 20;
            int c = 10;

            Console.WriteLine("the current value of a is " + a);
            Console.WriteLine("the current value of b is " + b);

            //after swaping value
            c = a;
            a = b;
            b = c;

            Console.WriteLine("the new value of a is " + a);
            Console.WriteLine("the new value of b is " + b);

           // first character of each name
            int i;

            List<string> name = new List<string>();
            name.Add("adam");
            name.Add("bob");
            name.Add("colon");

            for (i = 0; i <= 0; i++)
            {
                Console.WriteLine(name[0][0]);
                Console.WriteLine(name[1][0]);
                Console.WriteLine(name[2][0]);

            }

           // reverse order

            int i;
            List<int> num = new List<int>() { 1, 2, 3, 4, 5 };
            for (i = num.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(num[i]);
            }

            //Print odd index value
            int i;

            List<int> num= new List<int>() { 1,2,3,4,5,6};

            for (i=0; i<=num.Count; i++)
            if(i%2!=0)
                {
                    Console.WriteLine(i);
                }



            














        }

    }
}
