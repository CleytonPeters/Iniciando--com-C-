using System;
using System.Globalization;

namespace ExercicioFixacaoAula45_3 {
    class Aluno {
        public string Nome;
        public double Nota1, Nota2, Nota3;
        public double NotaFinal() {
            return Nota1 + Nota2 + Nota3;
        }
      
        public bool Aprovado() {
            if(NotaFinal() >= 60) {
                return true;
            } else {
                return false;
            }
        }

        public double Faltaram() {
            return 60 - NotaFinal(); 
        }


    }
}
