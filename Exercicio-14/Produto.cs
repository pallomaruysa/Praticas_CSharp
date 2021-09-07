using System;
using System.Globalization;

namespace Exercicio_14
{
    public class Produto
    {
        public string  Nome;
        public double  Preco;
        public int  Quantidade;

        public double ValorTotalEmEstoque(){
            return Preco * Quantidade;
        }

        public override string ToString(){
            return Nome+", R$ "+
            Preco.ToString("F2", CultureInfo.InvariantCulture)+" com "+
            Quantidade+" no estoque. \nTotal: R$ "+
            ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}