using System;
using System.Globalization;

namespace MembrosEstaticosAula46 {
    class Program {
        static double Pi = 3.14;
        static void Main(string[] args) {
            Console.Write("Entre com o valor de raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = RetornaRaio(raio);
            double volume = Volume(raio);
            Console.WriteLine("A circunferência é de: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O Volume é de: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Pi);
        }

        static double RetornaRaio(double r) {
            return 2.0 * Pi * r; 
        }
        static double Volume(double r) {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }

    }
}
