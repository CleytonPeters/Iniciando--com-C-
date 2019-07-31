using System;
using System.Collections.Generic;

namespace Aula81_ExercicioFixacao {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o número de Colunas: ");
            int Column = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de Linhas: ");
            int Line = int.Parse(Console.ReadLine());

            int[,] matriz = new int[Line, Column];

            for (int i = 0; i < Line; i++) {
                for(int y = 0; y < Line; y++) {
                    Console.WriteLine($"Digite os {Column} nº inteiros da Coluna {(i+1)}: ");
                    string[] values = Console.ReadLine().Split(' ');
                    matriz[y, i] = int.Parse(values[y]);
                }
            }
            


        }
    }
}
