using System;
using System.Globalization;

namespace MembrosEstaticosParte2 {
    class Program {
        static double Pi = 3.14;
        static void Main(string[] args) {

            Console.Write("Entre com o valor de raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.RetornaRaio(raio);
            double volume = Calculadora.Volume(raio);
            Console.WriteLine("A circunferência é de: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O Volume é de: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Pi);
        }        
    }
}
