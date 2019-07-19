using System;
using System.Globalization;

namespace PrimeiroProjetoOOP {
    class Program {
        static void Main(string[] args) {
           
            //Pessoa maria = new Pessoa();
            //Pessoa joao = new Pessoa();


            //Console.WriteLine("Dados da Primeira Pessoa: ");
            //Console.Write("Nome: ");
            //maria.nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //maria.idade = int.Parse(Console.ReadLine());
            //Console.WriteLine("Dados da Segunda Pessoa: ");
            //Console.Write("Nome: ");
            //joao.nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //joao.idade = int.Parse(Console.ReadLine());
            //if(joao.idade > maria.idade) {
            //    Console.WriteLine($"A pessoa mais velha é João");
            //} else {
            //    Console.WriteLine($"A pessoa mais velha é Maria");
            //}

            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            funcionario1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.salario = double.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            funcionario2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.salario = double.Parse(Console.ReadLine());

            double mediaSalarial = (funcionario1.salario + funcionario2.salario) / 2;
            Console.WriteLine("Salario Médio: " + mediaSalarial.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
