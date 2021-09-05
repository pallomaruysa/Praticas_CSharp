using System;

namespace Exercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int numAprovados = 0, numReprovados = 0, contadorAlunos = 1, resultadoExame;

            while (contadorAlunos <= 10)
            {
                 Console.WriteLine("Digite Resultado (1 = APROVAR |  2 = REPROVAR): ");
                 resultadoExame = Int32.Parse(Console.ReadLine());

                 if(resultadoExame == 1)
                    numAprovados++;
                 
                 else
                    numReprovados++;  

                contadorAlunos++;    
            }

            Console.WriteLine();
            Console.WriteLine("Aprovados: "+numAprovados);
            Console.WriteLine("Reprovados: "+numReprovados);

            if(numAprovados > 8 )
                Console.WriteLine("Aumentar valor do curso\n");
        }
        
    }
}
