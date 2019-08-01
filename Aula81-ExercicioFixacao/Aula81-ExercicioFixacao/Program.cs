using System;
using System.Collections.Generic;

namespace Aula81_ExercicioFixacao {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter the number of columns: ");
            int column = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of lines: ");
            int line = int.Parse(Console.ReadLine());

            int[,] matriz = new int[line, column];

            for (int i = 0; i < column; i++) {
                Console.WriteLine($"Enter the {column} nº intenger of column {(i + 1)}: ");
                string[] values = Console.ReadLine().Split(' ');
                for (int y = 0; y < line; y++) {
                    matriz[y, i] = int.Parse(values[y]);
                }
            }
            Console.WriteLine();
            Console.Write("Search for number: ");
            int positionNumber = int.Parse(Console.ReadLine());

            for (int a = 0; a < column; a++) {
                for (int b = 0; b < line; b++) {
                    if (matriz[a, b] == positionNumber) {
                        Console.WriteLine("Line " + (b + 1) + " Column " + (a + 1));
                        if (a > 0 && b >= 0) {
                            Console.WriteLine("Left: " + matriz[(a - 1), b]);
                        }
                        if (a < (line - 1)) {
                            Console.WriteLine("Right: " + matriz[(a + 1), b]);
                        }
                        if (b > 0) {
                            Console.WriteLine("Up: " + matriz[a, (b - 1)]);
                        }
                        if (b < (column - 1)) {
                            Console.WriteLine("Down: " + matriz[a, (b + 1)]);
                        }
                    }
                }
            }



        }
    }
}
