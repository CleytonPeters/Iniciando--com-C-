using System;
using System.Globalization;

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
