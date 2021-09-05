using System;
using System.Globalization;

namespace Exercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma quantia em dólares para a conversão em reais");
            string valorString = Console.ReadLine();
            double valorDolar = Convert.ToDouble(valorString);
            double operacao = valorDolar * 5.25;
            Console.WriteLine("O valor em convertido fica em R$"+operacao.ToString("F2", CultureInfo.InvariantCulture)); 
        }
    }
}


