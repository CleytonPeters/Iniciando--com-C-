using System;

namespace Aula56_Properties {
    class Program {
        static void Main(string[] args) {

            Produto produto = new Produto("TV", 900.0);
            produto.Nome = "TV";

            String nome = produto.Nome;
            Console.WriteLine(nome);
            Console.WriteLine(produto.Preco);

        }
    }
}
