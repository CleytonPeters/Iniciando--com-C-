using System;

namespace Aula80ExercicioResolvido {
    class Program {
        static void Main(string[] args) {

            int qt = int.Parse(Console.ReadLine());

            int[,] mat = new int[qt, qt];

            for (int i = 0; i < qt; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < qt; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }

            }

            Console.WriteLine("Main diagonal: ");
            for (int x = 0; x < qt; x++) { //pegar a posição x do mat e imprimir na tela efeito diagonal 0,0 1,1, 2,2...
                Console.Write(mat[x , x] + " "); 
            }

            int count = 0;
            for (int i = 0; i < qt; i++) { //for para verificar todas as colunas e linhas se são menores que 0 acrescentar +1 na variavel count.
                for (int z = 0; z < qt; z++) {
                    if(mat[i , z] < 0) {
                        count++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Negative numbers = " + count);
        }
    }
}
