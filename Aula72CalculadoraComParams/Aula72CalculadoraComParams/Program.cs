using System;

namespace Aula72CalculadoraComParams {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine(Calculator.Sum(2, 3, 5));
            Console.WriteLine(Calculator.Subtraction(100, 25));
            int x = 10;
            Calculator.Triple(ref x);
            Console.WriteLine(x);


            int y = 10;
            int triple;
            Calculator.Tripla(y, out triple);
            Console.WriteLine(triple);



        }
    }
}
