using System;
using System.Globalization;

namespace ContaBancaria {
    class Program {
        static void Main(string[] args) {
            
            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o títular da conta: ");
            String nome = Console.ReadLine();
            Conta c2 = TipoConta(conta, nome);

            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(c2);

            Console.Write("Entre com um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine());

            c2.Depositar(quantia);
            Console.WriteLine(c2);

            Console.Write("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine());
            c2.Sacar(quantia);
            Console.WriteLine(c2);

        }
        static Conta TipoConta(int conta, string nome) {
            Console.Write("Haverá depósito inicial (s/n)? ");
            String resultado = Console.ReadLine().ToLower();

            if (resultado == "n") {
                return new Conta(conta, nome);
            } else if (resultado == "s") {
                Console.Write("Entre com o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine());
                return new Conta(conta, nome, saldo);
            } else return TipoConta(conta, nome);
        }
    }
}
