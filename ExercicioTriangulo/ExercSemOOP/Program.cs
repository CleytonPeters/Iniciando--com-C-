using System;

namespace ExercSemOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();


            Console.WriteLine("Entre com as medidas do Triangulo X:");
            Console.Write("Lado A:");
            x.A = double.Parse(Console.ReadLine());
            Console.Write("Lado B:");
            x.B = double.Parse(Console.ReadLine());
            Console.Write("Lado C:");
            x.C = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("-----------------");

            Console.WriteLine("Entre com as medidas do Triangulo Y:");
            Console.Write("Lado A:");
            y.A = double.Parse(Console.ReadLine());
            Console.Write("Lado B:");
            y.B = double.Parse(Console.ReadLine());
            Console.Write("Lado C:");
            y.C = double.Parse(Console.ReadLine());

            Console.WriteLine(x.Area().ToString("F2"));
            Console.WriteLine(y.Area().ToString("F2"));
        }
    }
}
