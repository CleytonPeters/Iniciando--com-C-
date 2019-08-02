using System;

namespace Aula88_SintaxeCondicionalTernaria {
    class Program {
        static void Main(string[] args) {

            double preco = 21.0;

            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.5;

            Console.WriteLine(desconto);
        }
    }
}
