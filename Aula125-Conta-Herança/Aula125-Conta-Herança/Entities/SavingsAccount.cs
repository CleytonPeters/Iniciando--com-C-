using System;
using System.Collections.Generic;
using System.Text;

namespace Aula125_Conta_Herança.Entities
{
    class SavingsAccount : Account //herda de account
    {

        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

    }
}
