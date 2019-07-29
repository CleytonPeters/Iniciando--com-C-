using System;
using System.Globalization;

namespace Aula69_Vetores {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o número de pessoas: ");
            int tamanho = int.Parse(Console.ReadLine());

            double[] altura = new double[tamanho];
            double soma = 0.0;

            for (int i = 0; i < altura.Length; i++) {
                altura[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += altura[i];
            }

            double media = soma / tamanho;
            Console.WriteLine("AVARAGE HEIGHT = " + media.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
