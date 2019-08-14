using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_133_Classes_Abstratas.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }
        public void UpdateBalance()
        {
             
        }

    }
}
