using System;
using System.Globalization;

namespace Aula55_Encapsulamento {
    class Produto {

        private string _nome;
        private double _preco;
        private int _quantidade;

        public String GetNome() {
            return _nome;
        }

        public void SetNome(String nome) {
            if(nome != null && nome.Length > 1) {
                _nome = nome;
            }
        }
        public double  GetPreco() {
            return _preco;
        }

        public int GetQuantidade() {
            return _quantidade;
        }
        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }
        public void RemoverProduto(int quantidade) {
            _quantidade -= quantidade;
        }

    }
}
