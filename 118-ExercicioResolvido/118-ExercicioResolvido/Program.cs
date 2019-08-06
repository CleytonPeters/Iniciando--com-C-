using System;
using System.Globalization;
using _118_ExercicioResolvido.Entities;
using _118_ExercicioResolvido.Entities.Enums;

namespace _118_ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("Enter departament's name: ");
            string deptName = Console.ReadLine(); //nome do departamento
            
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine(); //nome do funcionario
         
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine()); //level do funcionario

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //salario base

            Departament dpt = new Departament(deptName);

            Worker worker = new Worker(name, level, baseSalary, dpt);
                       
            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine()); //quantidade de contratos

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Enter #{(i)} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hours: "); 
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): " );
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Departament: " + worker.Departament.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
