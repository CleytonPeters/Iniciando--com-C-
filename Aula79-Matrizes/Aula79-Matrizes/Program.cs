using System;

namespace Aula79_Matrizes {
    class Program {
        static void Main(string[] args) {

            double[,] matriz = new double[2, 3]; //Cria - 2 linhas e 3 coluna.
            Console.WriteLine(matriz.Length); //total de espaço 2*3 = 6 espaços.
            Console.WriteLine(matriz.Rank); // quantidade de linhas 2 na coluna.
            //Console.WriteLine(matriz.GetLength(0));
            for(int i = 0; i < 3; i++) {




            }
            Console.WriteLine(matriz.Equals(3));

            //matriz[0, 0] = 2.1;
            //Console.WriteLine(matriz[0,0]);





        }
    }
}
