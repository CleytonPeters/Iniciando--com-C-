using System;

namespace ExercicioFixacaoAula45 {
    class Program {
        static void Main(string[] args) {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e a altura do retângulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine());
            retangulo.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Area = " + retangulo.Area());
            Console.WriteLine("Perímetro = " + retangulo.Perimetro());
            Console.WriteLine("Diagonal = " + retangulo.Diagonal());
        }
    }
}
