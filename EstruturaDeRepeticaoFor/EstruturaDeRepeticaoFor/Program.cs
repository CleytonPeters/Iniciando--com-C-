using System;
using System.Globalization;

namespace EstruturaDeRepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int quantidade = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= quantidade; i++)
            {
                Console.Write($"Digite o #{i}:");
                int valor = int.Parse(Console.ReadLine());
                soma += valor;

            }

            Console.WriteLine($"A soma total é de: {soma}");











        }
    }
}
