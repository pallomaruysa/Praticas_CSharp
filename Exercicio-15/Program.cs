using System;
using System.Collections;

namespace Exercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList listaNotas = new ArrayList();
            Notas n = new Notas();   
            int loop;
            double contNotas=0.0;

            Console.WriteLine("\n \t\t\t\t Seja bem-vindo ao WellPlus");
            Console.WriteLine("\t\t Digite aqui suas notas para saber como vai seu rendimento ;-)");

            do{
                Console.WriteLine("\nDigite o nome da matéria");
                n.Materia = Console.ReadLine();

                Console.WriteLine("Digite quantas notas deseja adicionar");
                int qntNotas = int.Parse(Console.ReadLine());

                for(int i=0; i<qntNotas; i++){
                    Console.WriteLine("\nNota: ");
                    n.Nota = double.Parse(Console.ReadLine());
                    listaNotas.Add(n.Nota);
                    contNotas+=(double)listaNotas[i];
                }



                Console.WriteLine("\nRESULTADO: ");
                
                for(int i=0; i<qntNotas; i++){
                    Console.WriteLine(listaNotas[i]);
                }

                Console.WriteLine("\nMédia: "+n.Media(contNotas, qntNotas));


                Console.WriteLine("-----------------------------------------------------------------------------\n\n");

                listaNotas.Clear();

                Console.WriteLine("Deseja adicionar mais alguma nota? (1 - sim | 2 - não)");
                loop = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------------------------------------------------\n\n");
            }while(loop != 2);
        }
    }
}
