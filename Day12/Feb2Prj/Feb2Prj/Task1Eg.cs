﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb2Prj
{

    class Account
    {
        static int amount;
        public Account(int amt)
        {
            amount = amt;
            

        }

        public void Credit(int amt)
        {
            amount += amt;
            Console.WriteLine($"THe Credit Balance is {amount}");
        }

        public void Debit(int amt)
        {
            amount -= amt;
            Console.WriteLine($"THe Debit Balance is {amount}");
        }

    }
    class Task1Eg
    {
        static void Main()
        {
            var account = new Account(1000);
            var tasks = new Task[50];
            for(int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Run(() => RandomlyUpdate(account));
            }
            Task.WaitAll(tasks);        
            Console.ReadKey();
        }

        static void RandomlyUpdate(Account account)
        {
            var rnd = new Random();
            for(int i = 0; i <= 10; i++)
            {
                var amount = rnd.Next(100,500);
                double d = rnd.NextDouble();
                bool docredit = d < 0.5;
               // bool docredit = rnd.NextDouble() < 0.5;
                if (docredit)
                {
                    account.Credit(amount);

                }
                else
                {
                    account.Debit(amount);
                }
            }
        }
    }
}
