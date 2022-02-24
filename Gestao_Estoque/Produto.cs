using System;
using System.Globalization;

namespace Gestao_Estoque
{
    class Produto : IProduto
    {
        public String nomeProduto;
        public double valorProduto;
        public int Quantidade;

        public void AdicaoProdutos(int quantidade){
            Quantidade += quantidade;
        }

        public void RemocaoProdutos(int quantidade){
            Quantidade -= quantidade;
        }
        public double Total(){
            return valorProduto * Quantidade;
        }

        public void tipoProduto()
        {
            Console.WriteLine("Insira o tipo do Produto");
            Console.ReadLine();
        }

        public override string ToString()
        {
            return "Produto: " +nomeProduto +" Valor: R$"+valorProduto.ToString("F2", CultureInfo.InvariantCulture)
            + ", " + Quantidade + " unidades, Total:R$"
            + Total().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}