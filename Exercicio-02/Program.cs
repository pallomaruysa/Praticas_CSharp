using System;
using System.Globalization;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            
            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234567;


            Console.WriteLine("PRODUTOS");
            Console.WriteLine(produto1+", cujo o preço é R$"+preco1);
            Console.WriteLine(produto2+", cujo o preço é R$"+preco2);
            Console.WriteLine("REGISTROS");
            Console.WriteLine(idade+" anos de idades, código "+codigo+" e gênero "+genero);
            Console.WriteLine("Medida com oito casas decimais "+medida);
            Console.WriteLine("Separador decimal Invariant culture: "+medida.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
