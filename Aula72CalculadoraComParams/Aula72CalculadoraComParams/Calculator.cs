using System;
using System.Collections.Generic;
using System.Text;

namespace Aula72CalculadoraComParams {
    class Calculator {

        public static double Sum(params double[] numbers) {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }

        public static double Subtraction(params double[] numbers) {
            double subtraction = 0;
            for(int i = 0; i < numbers.Length; i++) {
                subtraction -= numbers[i];
            }
            return subtraction;
        }

        public static void Triple(ref int x) { // utilizando ref
            x = x * 3;
        }

        public static void Tripla(int origin, out int result) { //utilizando Out
            result = origin * 3;
        }


    }
}
