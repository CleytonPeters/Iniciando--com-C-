using System;

namespace EntradaDeDados1
{
    class Program
    {
        private static object s;

        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a Frase: ");
            String frase = Console.ReadLine();
            String x = Console.ReadLine();
            String y = Console.ReadLine();
            String z = Console.ReadLine();
            
            String[] vet = Console.ReadLine().Split(' ');
            String a = vet[0];
            String b = vet[1];
            String c = vet[2];

            Console.WriteLine("Você escreveu: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
