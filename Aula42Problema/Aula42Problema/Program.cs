using System;
using System.Globalization;

namespace Aula42Problema {
    class Program {
        static void Main(string[] args) {
            Produto p1 = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p1.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            p1.Quantidade = int.Parse(Console.ReadLine());
            
            

           Console.WriteLine("Dados do produto: " + p1);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            p1.AdicionarQuantidade = int.Parse(Console.ReadLine());
            p1.AdicionaProduto(p1.AdicionarQuantidade);
            Console.WriteLine("Dados do atualizados: " + p1);

            Console.Write("Digite o número de produtos a ser removida do estoque: ");
            p1.RemoveQuantidade = int.Parse(Console.ReadLine());
            p1.RemoveProduto(p1.RemoveQuantidade);
            Console.WriteLine("Dados do atualizados: " + p1);

        }
    }
}
