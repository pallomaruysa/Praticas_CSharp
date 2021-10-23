using System;
using System.Globalization;

namespace Exercicio_14
{
    public class Produto
    {
        public int Codigo;
        public string  Nome;
        public double  Preco;
        public int  Quantidade;

        public double ValorTotalEmEstoque(){
            return Preco * Quantidade;
        }
        public void AdicionarProduto(int quantidade){
                Quantidade +=quantidade;
        }

        public void RemoverProduto(int quantidade){
                Quantidade -=quantidade;
        }

        public override string ToString(){
            return "\nId do produto: "+Codigo+"  |  "+Nome+", R$ "+
            Preco.ToString("F2", CultureInfo.InvariantCulture)+" com "+
            Quantidade+" no estoque. \nTotal: R$ "+
            ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}