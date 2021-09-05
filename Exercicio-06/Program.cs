using System;

namespace Exercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int total, qtdNotas, valorNota, valorPeso;
            double media;

            total = 0;
            qtdNotas = 0;

            while(qtdNotas<5){
                Console.WriteLine("Digite a nota: ");
                valorNota = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Digite o peso da nota: ");
                valorPeso = Int32.Parse(Console.ReadLine());

                total += valorNota*valorPeso;
                qtdNotas++;
            }

            media = total/qtdNotas;

            Console.WriteLine("Média de notas é {0}",media);
            Console.WriteLine(qtdNotas);
        }
    }
}


