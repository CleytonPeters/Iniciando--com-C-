using System;

namespace Aual75SintaxeForeach {
    class Program {
        static void Main(string[] args) {

            Object[] obj = new Object[] { "Luana", "Tiago", "Cleyton", "Priscila" };

            foreach(Object banana in obj) {
                Console.WriteLine(banana);
            }

            int[] numeros = new int[] { 1, 2, 3, 5, 8, 13 };
            foreach(int numbers in numeros) {
                Console.WriteLine(numbers);
            }

            double[] vectDouble = new double[] { 2.0, 3.0, 4.0, 5.0 };
            foreach(double kaka in vectDouble) {
                Console.WriteLine(kaka);
            }

            string[] sobrenomes = new string[] { "Peters", "Schmitt" };
            foreach(string apelido in sobrenomes) {
                Console.WriteLine(apelido);
            }

        }
    }
}
