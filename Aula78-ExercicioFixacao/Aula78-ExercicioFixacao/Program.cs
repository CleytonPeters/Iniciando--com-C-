using System;
using System.Collections.Generic;
namespace Aula78_ExercicioFixacao {
    class Program {
        static void Main(string[] args) {
            Console.Write("How many employees will be registered?   ");
            int quantity = int.Parse(Console.ReadLine());

            List<object> funcionarios = new List<object>();
            for(int i=0; i < quantity; i++) {
                Console.WriteLine("Emplyoee #" + (i+1));
                Console.Write("Id: ");                
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary =  double.Parse(Console.ReadLine());
                funcionarios[i] = new Employees { Name = name, Id = id, Salary = salary};
            }

            foreach(object obj in funcionarios) {
                Console.WriteLine(obj);
            }



        }
    }
}
