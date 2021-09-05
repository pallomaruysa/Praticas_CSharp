using System;

namespace Exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int contadorClientesFila = 1, temCliente = 0, semCliente = 0, resultadoClientesFila;

            while (contadorClientesFila <= 15)
            {
                Console.WriteLine("Digite se tem cliente na fila (1 = Tem cliente na fila | 2 = Não tem cliente na fila");
                resultadoClientesFila = Int32.Parse(Console.ReadLine());

                if (resultadoClientesFila == 1)    
                        temCliente++;

                else
                     semCliente++;

                contadorClientesFila++;
            }
            Console.WriteLine();
            Console.WriteLine("Pessoas na fila: "+temCliente);
            Console.WriteLine("Pessoas já atendidas: "+semCliente);
            Console.WriteLine();

            if(temCliente >= 15)
                Console.WriteLine("Chame mais um funcionário para atender os clientes\n");
        }
    }
}
