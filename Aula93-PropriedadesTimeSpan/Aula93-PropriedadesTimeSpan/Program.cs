using System;

namespace Aula93_PropriedadesTimeSpan {
    class Program {
        static void Main(string[] args) {

            TimeSpan t = new TimeSpan(2, 8, 50, 30);
            Console.WriteLine("Days: " + t.Days);


            TimeSpan tempo1 = new TimeSpan(2, 05, 00);
            TimeSpan tempo2 = new TimeSpan(0, 15, 00);

            TimeSpan total = tempo1 + tempo2; //ou tempo1.Add(tempo2)
            TimeSpan subtract = tempo1.Subtract(tempo2);
            TimeSpan mult = tempo2.Multiply(2.0);
            TimeSpan div = tempo2.Divide(2.0);
            Console.WriteLine("Soma de horas: " + total);
            Console.WriteLine("\nSubtração de horas: " + subtract);
            Console.WriteLine("\nMultiplicação de horas: " + mult);
            Console.WriteLine("\nDivisão de horas: " + div);
        }
    }
}
