using System;
namespace Aula42Problema {
    class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;
        public int AdicionarQuantidade;
        public int RemoveQuantidade;
               
        public double ValorTotalEmEstoque() {
            return Quantidade * Preco;
        }
        public void AdicionaProduto(int quantity) {
            Quantidade += quantity;
            ValorTotalEmEstoque();
        }
        public void RemoveProduto(int quantity) {
            Quantidade -= quantity;
            ValorTotalEmEstoque();
        }


    }
}
