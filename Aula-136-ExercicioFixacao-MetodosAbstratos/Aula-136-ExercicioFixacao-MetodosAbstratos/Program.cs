using System;
using System.Collections.Generic;
using System.Globalization;
using Aula_136_ExercicioFixacao_MetodosAbstratos.Entities;
namespace Aula_136_ExercicioFixacao_MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contributor> contributor = new List<Contributor>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthSpending = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    contributor.Add(new Individual(name, annualIncome, healthSpending));
                } else
                {
                    Console.Write("Number employees: ");
                    int employeesNumber = int.Parse(Console.ReadLine());
                    contributor.Add(new Company(name, annualIncome, employeesNumber));
                }


            }

            Console.WriteLine("TAXES PAID: ");
            double sum = 0;
            foreach (Contributor total in contributor)
            {
                Console.WriteLine(total.Name + ": $ " + total.Taxes().ToString("F2", CultureInfo.InvariantCulture));
                sum += total.Taxes();
            }
            Console.WriteLine("TOTAL TAXES: " + sum.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
