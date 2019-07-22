using System;
using System.Globalization;

namespace ExercicioFixacaoAula45_2 {
    class Funcionario {

        public String Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem) {
            porcentagem = (SalarioBruto * porcentagem) / 100;
            SalarioBruto += porcentagem;
        }

        public override string ToString() {
            return Nome 
                + ", $ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
