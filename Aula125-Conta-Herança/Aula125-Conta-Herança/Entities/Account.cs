using System;
using System.Collections.Generic;
using System.Text;

namespace Aula125_Conta_Herança.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public String Holder { get; private set; }
        public Double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount) //precisa colocar o virtual para ele poder sobreescrever na outra classe
        {
            Balance -= amount + 5;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        } 
    }
}
