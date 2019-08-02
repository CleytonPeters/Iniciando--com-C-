using System;
using System.Collections.Generic;

namespace Aula83_ExercicioFixacao_Conjuntos {
    class Program {
        static void Main(string[] args) {

            HashSet<int> CodeA = new HashSet<int>();
            HashSet<int> CodeB = new HashSet<int>();
            HashSet<int> CodeC = new HashSet<int>();


            Console.Write("O curso A possui quantos alunos? ");
            int AlunosA = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A: ");

            for(int i = 0; i < AlunosA; i++) {
                int x = int.Parse(Console.ReadLine());
                CodeA.Add(x); 
            }
            //------------------------------------
            Console.Write("O curso B possui quantos alunos? ");
            int AlunosB = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B: ");

            for (int i = 0; i < AlunosB; i++) {
                int x = int.Parse(Console.ReadLine());
                CodeB.Add(x);
            }
            //-----------------------------
            Console.Write("O curso A possui quantos alunos? ");
            int AlunosC = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C: ");

            for (int i = 0; i < AlunosC; i++) {
                int x = int.Parse(Console.ReadLine());
                CodeC.Add(x);
            }

            CodeA.UnionWith(CodeB);
            CodeA.UnionWith(CodeC);

            Console.WriteLine("Total de alunos: " + CodeA.Count);




        }
    }
}
