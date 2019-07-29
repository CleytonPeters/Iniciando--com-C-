using System;
using System.Globalization;

namespace Aula56_Properties {
    class Produto {

        private string _nome;
        public double Preco { get; private set; } //autoproperties
        public int Quantidade { get; private set; } //autoproperties

        public Produto(string _nome, double preco) {
            Nome = _nome;
            Preco = preco;
        }

        public string Nome { //properties
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        //public double Preco {   //properties
        //    get { return _preco; }
        //}

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProduto(int quantidade) {
            Quantidade -= quantidade;
        }

    }
}
