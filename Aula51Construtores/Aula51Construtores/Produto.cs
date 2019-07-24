using System;
using System.Globalization;

namespace Aula51Construtores {
    class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;
        public int AdicionarQuantidade;
        public int RemoveQuantidade;

        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) { //pode se criar mais de um construtor. Sobrecarga
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
        }

        public double ValorTotalEmEstoque() {
            return Quantidade * Preco;
        }
        public void AdicionaProduto(int quantity) {
            Quantidade += quantity;
        }
        public void RemoveProduto(int quantity) {
            Quantidade -= quantity;
        }

        public override string ToString() {  //sobrescreve
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
