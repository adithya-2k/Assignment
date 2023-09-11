﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dotnet
{
    class Assignment4
    {
        static void Main(string[] args)
        {
            Console.Write("What is the transaction method: \n" +
                   "Press 1 for Deposite \n" +
                   "Press 2 for Withdrawal \n");
            int Transaction_type = Convert.ToInt32(Console.ReadLine());


            Account account1 = new Account("1033015","Adithya","Savinga",10000);

            if (Transaction_type == 1)
            {
                account1.credit();
            }
            else
            {
                account1.debit();
            }

        }
        public class Account
        {
            string Account_no;
            string Customer_name;
            public string Account_type;
            string Transaction_type;
            decimal Amount;
            decimal Balance;

            public Account(string Account_no, string Customer_name, string Account_type, decimal Balance)
            {
                this.Account_no = Account_no;
                this.Customer_name = Customer_name;
                this.Account_type = Account_type;
                this.Balance = Balance;

            }

            public void credit()
            {

                Console.Write("Enter the amount: ");
                Amount = Convert.ToDecimal(Console.ReadLine());
                Balance = Balance + Amount;
                Console.WriteLine($"your Account number is {Account_no} \n " +
                    $"Your name is {Customer_name} \n" +
                    $"Your account type is {Account_type} \n" +
                    $"The amount you credited is {Amount} \n" +
                    $"Your current balance is {Balance} \n");
                Console.Read();
            }

            public void debit()
            {
                Console.Write("Enter the amount: ");
                Amount = Convert.ToDecimal(Console.ReadLine());
                Balance = Balance - Amount;
                Console.WriteLine($"your Account number is {Account_no} \n " +
                   $"Your name is {Customer_name} \n" +
                   $"Your account type is {Account_type} \n" +
                   $"The amount you Debited is {Amount} \n" +
                   $"Your current balance is {Balance} \n");
                Console.Read();

            }
            


        }
       

    }
}
