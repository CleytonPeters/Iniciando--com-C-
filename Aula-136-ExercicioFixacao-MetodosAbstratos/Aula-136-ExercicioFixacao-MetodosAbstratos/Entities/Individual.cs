using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_136_ExercicioFixacao_MetodosAbstratos.Entities
{
    class Individual : Contributor
    {
        public double HealthSpending { get; set; }

        public Individual(string name, double annualIncome, double healthSpending) : base(name, annualIncome)
        {
            HealthSpending = healthSpending;
        }

        public override double Taxes()
        {
            if (AnnualIncome < 20000)
            {

                return AnnualIncome * 0.15 - HealthSpending * 0.5;

            } else
            {
                return AnnualIncome * 0.25 - HealthSpending * 0.5;
            }
        }
    }
}
