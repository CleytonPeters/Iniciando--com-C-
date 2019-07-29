using System;

namespace Aula66TipoReferencia {
    class Program {
        static void Main(string[] args) {
            Point p; //não precisa escrever new Point();
            p.x = 10;
            p.y = 29;
            Console.WriteLine(p);
        }
    }
}
