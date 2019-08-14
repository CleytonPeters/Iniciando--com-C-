using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_133_Classes_Abstratas.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if(LoanLimit <= amount)
            {
                Balance += amount;
            }
        }
    }
}
