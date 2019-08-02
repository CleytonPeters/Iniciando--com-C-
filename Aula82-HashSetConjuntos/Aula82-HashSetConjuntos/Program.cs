using System;
using System.Collections.Generic;

namespace Aula82_HashSetConjuntos {
    class Program {
        static void Main(string[] args) {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(2);

            B.Add(3);
            B.Add(6);
            B.Add(5);

            //remove valores que são iguais no B.
            //A.ExceptWith(B);

            //une valores de B com A.
            //A.UnionWith(B);

            //valores em comum entre A e B.
            A.IntersectWith(B);


            foreach(int x in A) {
                Console.WriteLine(x);
            }

            Console.Write("Digite um valor inteiro para verificar: ");
            int N = int.Parse(Console.ReadLine());

            if(B.Contains(N)) {
                Console.WriteLine($"Possui o valor {N} na Lista B");
            } else {
                Console.WriteLine("Não possui.");
            }

        }
    }
}
