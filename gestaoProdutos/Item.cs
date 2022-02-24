using System;
using System.Globalization;

namespace gestaoProdutos
{
    public class Item : IProduto
    {
        public String nomeProduto { get; set; }
        public String tipoProduto { get; set; }
        public double valorProduto { get; set; }
        public int Quantidade { get; set; }
        public double Total()
        {
            return valorProduto * Quantidade;
        }
        public string TipoProduto()
        {
            Console.WriteLine("Insira o tipo do Produto");
            string value =  Console.ReadLine();
            return value;
        }

        public override string ToString()
        {
            return "Produto: " + nomeProduto + " Valor: R$" + valorProduto.ToString("F2", CultureInfo.InvariantCulture)
            + ", " + Quantidade + " unidades, Total:R$"
            + Total().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}