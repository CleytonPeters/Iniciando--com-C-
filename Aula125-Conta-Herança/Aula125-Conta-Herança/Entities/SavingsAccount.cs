using System;
using System.Collections.Generic;
using System.Text;

namespace Aula125_Conta_Herança.Entities
{   
    //sealed serve para "selar" a classe, então nenhuma classe poderá herdar dela. só escrever - sealed class SavingsAccount : Account
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

        //sealed proibe de sobreescrever o metodo withdraw dentro da classe SavingsAccount
        public sealed override void Withdraw(double amount) //precisa do virtual na classe pai para sobreescrever o método.
        {
            base.Withdraw(amount); //posso executar a tarefa toda anterior e acrescentar mais alguma coisa, como dirar mais 2.
            Balance -= 2;
            //Balance -= amount; //aqui sem o base ele só excluiria a taxa de 5.
        }


    }
}
