
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
            Bank b = new Bank()
            {

                FirstName = "Sam",
                InitialDeposit = 1000
            };

            Console.WriteLine("username is" + b.FirstName);
            Console.WriteLine(b.FirstName + "initial balance is " + b.InitialDeposit);

            b.Withdraw();

            int y = b.Save();
            Console.WriteLine(y);

            int z = b.Deposit();
            Console.WriteLine(z);

            b.GetUserInformation();

        }

        // You can define other methods, fields, classes and namespaces here

        public class Bank
        {

            public string FirstName { get; set; }
            public int InitialDeposit { get; set; }

            public void Withdraw()
            {
                int Withdraw;
                Console.WriteLine("Enter the amount you want to withdraw");
                Withdraw = Convert.ToInt32(Console.ReadLine());
                if (Withdraw <= InitialDeposit)
                {

                    Console.WriteLine("you can Withdraw the amount");
                }

                if (Withdraw > InitialDeposit)
                {

                    Console.WriteLine("Insufficient balance");

                }

            }



            public int Save()
            {
                int save;
                Console.WriteLine("Enter the amount you want to save");
                save = Convert.ToInt32(Console.ReadLine());
                save = InitialDeposit + save;
                {

                    Console.WriteLine("Your Current balance is " + save);

                }

                return save;
            }




            public int Deposit()

            {
                int deposit;
                Console.WriteLine("Enter the amount you want to deposit");
                deposit = Convert.ToInt32(Console.ReadLine());

                deposit = InitialDeposit + deposit;
                {

                    Console.WriteLine("now your current balance is " + deposit);
                }

                return deposit;

            }

            public void GetUserInformation()

            {
                Console.WriteLine("UserName is " + " " + FirstName);

                Console.WriteLine(FirstName + "Total Deposit is " + " " + InitialDeposit);

            }


        }
    }
}


        