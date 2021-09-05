using System;

namespace Exercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //para somar todos os pares de 0 a 100
            int soma = 0;
            for (int i = 0; i <= 100; i+=2)
            {
                soma += i;
            }

            Console.WriteLine("A soma de todos os valores pares de 0 a 100: "+soma);

            //para mostrar na tela todos os pares de 0 a 100
            for (int i = 0; i <= 100; i+=2)
            {
                Console.WriteLine(i);
            }        
        }
    }
}
