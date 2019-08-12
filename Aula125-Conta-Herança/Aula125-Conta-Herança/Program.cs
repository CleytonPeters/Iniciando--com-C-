using System;
using System.Globalization;
using Aula125_Conta_Herança.Entities;

namespace Aula125_Conta_Herança
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc = new Account(1020, "Cleyton", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.00);

            //UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(3032, "Jorge", 200.0, 900.00);
            Account acc3 = new SavingsAccount(201, "Roberto", 300.00, 20000.00);

            //DOWNCASTING   

            BusinessAccount bacc1 = (BusinessAccount)acc2;
          




        }
    }
}
