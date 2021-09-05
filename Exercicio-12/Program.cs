using System;

namespace Exercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            char nota;
            int numNota_A = 0, numNota_B = 0, numNota_C = 0, numNota_D = 0, numNota_E = 0, numNota_F = 0;
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Digite a letra da nota: ");
                nota = Char.Parse(Console.ReadLine());
            
                switch (nota)
                {
                    case 'A': case 'a': ++numNota_A;  break;
                    case 'B': case 'b': ++numNota_B;  break;
                    case 'C': case 'c': ++numNota_C;  break;
                    case 'D': case 'd': ++numNota_D;  break;
                    case 'E': case 'e': ++numNota_E;  break;
                    case 'F': case 'f': ++numNota_F;  break;
                    default:
                        Console.WriteLine("Letra da nota digitada incorreta"+"\nNota NÃO adicionada ao total"); break;
                }
            }

            Console.WriteLine("\nTotais para cada letra são:\nA: {0}\nB: {1}\nC: {2}\nD: {3}\nE: {4}\nF: {5}", numNota_A, numNota_B, numNota_C, numNota_D, numNota_E, numNota_F);
        }
    }
}
