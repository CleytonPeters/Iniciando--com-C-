using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_136_ExercicioFixacao_MetodosAbstratos.Entities
{
    class Company : Contributor
    {
        public int EmployeesNumber { get; set; }

        public Company(string name, double annualIncome, int employeesNumber) : base(name, annualIncome)
        {
            EmployeesNumber = employeesNumber;
        }

        public override double Taxes()
        {
            if(EmployeesNumber <= 10)
            {
                return (AnnualIncome * 16) / 100;
            }
            else
            {
                return (AnnualIncome * 14) / 100;
            }
        } 

    }
}
