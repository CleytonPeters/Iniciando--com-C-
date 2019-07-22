using System;
using System.Globalization;

namespace ExercicioFixacaoAula45_2 {
    class Program {
        static void Main(string[] args) {
            Funcionario fn = new Funcionario();

            Console.Write("Nome: ");
            fn.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            fn.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            fn.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            Console.WriteLine("Funcionário: " + fn);
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);           
            fn.AumentarSalario(porcento);
            Console.WriteLine();            
            Console.WriteLine("Dados atualizados: " + fn );

        }
    }
}
