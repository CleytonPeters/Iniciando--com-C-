using System;
using System.Globalization;
using System.Collections.Generic;
using Aula_134_MétodosAbstratos.Entities;
using Aula_134_MétodosAbstratos.Entities.Enum;
namespace Aula_134_MétodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangule or Circle (r/c): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black, Blue, Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                                
                if(ch == 'r')
                {
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangule(height, width, color));
                } else if(ch == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine("\nSHAPE AREAS:");
            foreach(Shape shape in list)
            {
                Console.WriteLine("Área: "+ shape.Area().ToString("F2", CultureInfo.InvariantCulture) + ", " + shape.Color);
            }
        }
    }
}
