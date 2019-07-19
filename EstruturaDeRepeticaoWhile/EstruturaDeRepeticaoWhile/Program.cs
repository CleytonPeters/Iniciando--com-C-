using System;
using System.Globalization;

namespace EstruturaDeRepeticaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Digite um número: ");
            //double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //while (x >= 0.0)
            //{
            //    double raiz = Math.Sqrt(x);
            //    Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
            //    Console.WriteLine("Digite outro número");
            //    x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //};
            //Console.WriteLine("Número negativo, terminou");

            Console.WriteLine("Digite um número: ");
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            do
            {
                if (y >= 0.0)
                {
                    double raiz = Math.Sqrt(y);
                    Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                    Console.WriteLine("Digite outro número");
                    y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
            } while (y >= 0.0);

        }
    }
}
