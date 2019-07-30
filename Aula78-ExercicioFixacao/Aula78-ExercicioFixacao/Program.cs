using System;
using System.Globalization;
using System.Collections.Generic;

namespace Aula78_ExercicioFixacao {
    class Program {
        static void Main(string[] args) {
            Console.Write("How many employees will be registered?   ");
            int quantity = int.Parse(Console.ReadLine());

            List<Employees> funcionarios = new List<Employees>();
            for(int i=1; i <= quantity; i++) {
                Console.WriteLine("Emplyoee #" + i);
                Console.Write("Id: ");                
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary =  double.Parse(Console.ReadLine());
                funcionarios.Add(new Employees { Name = name, Id = id, Salary = salary });
            }
            Console.Write("\nEnter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            Employees emp = funcionarios.Find(x => x.Id == searchId);
            if(emp != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            } else {
                Console.WriteLine("This id doesn't exist!");
            }
            Console.WriteLine();
            foreach (Employees obj in funcionarios) {
                Console.WriteLine(obj);
            }



        }
    }
}
