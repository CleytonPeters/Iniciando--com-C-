using System;

namespace Aula74BoxingAndUnboxing {
    class Program {
        static void Main(string[] args) {

            int x = 18;
            Console.WriteLine(x);

            Object obj = x;
            Console.WriteLine("Obj é = "+obj);

            Object novoObj = 324;
            Console.WriteLine("novoObj = " + novoObj);
            int y = (int)novoObj;
            Console.WriteLine("Converter objeto em int variavel Y = "  + y);

        }
    }
}
