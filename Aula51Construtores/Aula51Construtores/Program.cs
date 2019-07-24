using System;
using System.Globalization;

namespace Aula51Construtores {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            String nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            //Console.Write("Quantidade no estoque: ");
            //int quantidade = int.Parse(Console.ReadLine());

            Produto p1 = new Produto(nome, preco);

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