using System;
using System.Globalization;

namespace Aula70_Vetores {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] produto = new Produto[n];
            double media = 0;
            for(int i = 0; i < n; i++) {
                Console.Write("Produto: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço: ");
                double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                produto[i] = new Produto { Name = nomeProduto, Price = precoProduto};
                media += produto[i].Price;
            }
            media /= n;
            Console.WriteLine("Preço Médio: " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
