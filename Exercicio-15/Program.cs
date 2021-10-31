﻿using System;
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
            

            Console.WriteLine("\n \t\t\t\t Seja bem-vindo ao WellPlus");
            Console.WriteLine("\t\t Digite aqui suas notas para saber como vai seu rendimento ;-)");

            do{
                double contNotas=0.0;
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

                double media =  n.Media(contNotas, qntNotas);
                Console.WriteLine("\nMédia: "+media);

                listaNotas.Sort();
                for(int i=0; i<1; i++){
                   Console.WriteLine("Menor nota: "+listaNotas[0]);
                }

                listaNotas.Reverse();
                for(int i=0; i<1; i++){
                   Console.WriteLine("Maior nota: "+listaNotas[0]);
                }
                


                Console.WriteLine("-----------------------------------------------------------------------------\n\n");

                listaNotas.Clear();

                Console.WriteLine("Deseja adicionar mais alguma nota? (1 - sim | 2 - não)");
                loop = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------------------------------------------------\n\n");
            }while(loop != 2);
        }
    }
}
