using System;
using System.Globalization;

namespace ExercicioFixacaoAula48_1 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Qual é a cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares você vai comprar? ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double resultado = ConversoDeMoedas.Calcula(valor, cotacao);
            Console.Write("Valor a ser pago em reais = " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
