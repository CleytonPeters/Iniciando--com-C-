using System;
using System.Globalization;
using System.Collections.Generic;
using Aula130_ExercicioResolvido.Entities;

namespace Aula130_ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int N = int.Parse(Console.ReadLine());
                                 
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Employee #{i}");
                Console.Write("Outsourced (y/n)? ");
                char option = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double perHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (option == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, perHour, additional));
                } else
                {
                    list.Add(new Employee(name, hours, perHour));
                }


            }

            Console.WriteLine("PAYMENTS: ");
            foreach(Employee emp in list)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
