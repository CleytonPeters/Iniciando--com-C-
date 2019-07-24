using System;

namespace Aula55_Encapsulamento {
    class Program {
        static void Main(string[] args) {

            Produto produto = new Produto();
            produto.SetNome("TV"); //acima de 1 caracteres

            String nome = produto.GetNome();
            Console.WriteLine(nome);

        }
    }
}
