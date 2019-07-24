using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacaoAula48_1 {
    class ConversoDeMoedas {
        
        public static double Iof = 6.0;
        public static double Calcula(double Valor, double Cotacao) {
            return (Valor * Cotacao) * (Iof + 100) / 100;
        }

    }
}
