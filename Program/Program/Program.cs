using System;
using System.Globalization;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35564;
            string nome = "Maria Eduarda";

            Console.WriteLine("Hello World!"); //writeLine pula linha write não pula.
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); //transforma virgula em ponto.


            Console.Write("Bom Dia! ");
            Console.WriteLine("  Boa tarde");

            Console.WriteLine("");
            Console.WriteLine(nome + " Tem " + idade + " Anos e um saldo de " + saldo); //concatenação
            Console.WriteLine("");
            Console.WriteLine("{0} tem {1} anos e um saldo de {2:F2}", nome, idade, saldo); //placeholders
            Console.WriteLine("");
            Console.WriteLine($"{nome} tem {idade} e tem saldo igual a {saldo:F2} reais"); //interpolação só apartir do c# 6

        }
    }
}
