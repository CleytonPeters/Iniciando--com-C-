using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioResolvido_130.Entities;

namespace ExercicioResolvido_130
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine("Enter number of employees");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double perHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, perHour, additional));
                } else
                {
                    list.Add(new Employee(name, hours, perHour));
                }

            }

            Console.WriteLine("\nPAYMENTS: ");
            foreach (Employee items in list)
            {
                Console.WriteLine(items.Name + " - $ " + items.Payment());
            }
        }
    }
}
