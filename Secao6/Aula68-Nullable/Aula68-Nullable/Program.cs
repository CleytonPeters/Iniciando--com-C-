using System;

namespace Aula68_Nullable {
    class Program {
        static void Main(string[] args) {

            Nullable<double> z = null; //forma de fazer;
            double? x = null; //outra forma;
            double? y = 10;

            Console.WriteLine(x.HasValue); //x tem valor? retorna falso pois é null.
            Console.WriteLine(y.HasValue + "\n"); //y tem valor? retorna true pois tem o valor 10.

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault() + "\n");

            if(x.HasValue) {
                Console.WriteLine(x.Value);
            } else {
                Console.WriteLine("valor de x é nulo");
            } 
            if(y.HasValue) {
                Console.WriteLine(y.Value+"\n");
            } else {
                Console.WriteLine("o valor de y é nulo");
            }

            double k;
            k = x ?? 3.4; // k recebe x (Se X for null ele recerá 3.4)
            Console.WriteLine(k);




        }
    }
}
