using System;
using System.Collections.Generic;
using Aula_133_Classes_Abstratas.Entities;

namespace Aula_133_Classes_Abstratas
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Account> list = new List<Account>();
            double Sum = 0;

            list.Add(new SavingsAccount(111, "Alex", 200.50, 0.5));
            list.Add(new BusinessAccount(222, "Peters", 3000.00, 7000.00));

            foreach (Account lista in list)
            {
                Console.WriteLine("Name: " + lista.Holder + " Number Account: " + lista.Number + ", Balance: " + lista.Balance);
                Sum += lista.Balance;
            }
            Console.WriteLine(Sum);
        }
    }
}
