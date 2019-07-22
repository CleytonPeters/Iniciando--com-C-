using System;

namespace ExercicioFixacaoAula45_3 {
    class Program {
        static void Main(string[] args) {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine());
            aluno.Nota3 = double.Parse(Console.ReadLine());
            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal());
            if (aluno.Aprovado()) {
                Console.WriteLine("Aprovado");
            } else {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram " + aluno.Faltaram()  + " Pontos");
            }

        }
    }
}
