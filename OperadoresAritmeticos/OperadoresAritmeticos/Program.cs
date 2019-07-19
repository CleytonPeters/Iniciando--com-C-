using System;

namespace OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2; //11
            int n2 = (3 + 4) * 2; //14
            int n3 = 17 % 3; //resto é igual a  2
            int n4 = 10 / 8; //1 numero inteiro
            float n5 = (float) 10 / 8; //casting
            double n6 = 10.0 / 8;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); //function sqrt é raiz quadrada
            Console.WriteLine("Resultado: " + x1);


        }
    }
}
