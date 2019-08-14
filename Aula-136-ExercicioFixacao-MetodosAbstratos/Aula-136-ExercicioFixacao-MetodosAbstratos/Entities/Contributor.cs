using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_136_ExercicioFixacao_MetodosAbstratos.Entities
{
    abstract class Contributor
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Contributor(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }
        public abstract double Taxes();
    }
}
