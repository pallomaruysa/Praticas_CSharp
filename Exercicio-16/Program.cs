using System;
using System.Collections;

namespace Exercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList listaLivros = new ArrayList();
            Livros l = new Livros();

            int escolha, qnt, loop=0;

            Console.WriteLine("\t\t\t\t\tBem vindo a BooksLand");
            Console.WriteLine("\t\tSua nova blibioteca digital");

            do{
                Console.WriteLine("\n\tMENU");
                Console.WriteLine("Digite 1 -> Adicionar livro");
                Console.WriteLine("Digite 2 -> Remover livro");
                Console.WriteLine("Digite 3 -> Ver total de livros na bliblioteca");     
                Console.WriteLine("Digite 4 -> Sair do programa");     
                escolha = int.Parse(Console.ReadLine());
                
                switch(escolha){
                    case 1: 
                            Console.WriteLine("Digite quantos livros deseja adicionar");
                            qnt = int.Parse(Console.ReadLine());
                            l.AdicionarLivro(qnt);
                            Console.WriteLine("Livro adicionado com sucesso!");
                    break;
                    case 2: 
                            Console.WriteLine("Digite quantos livros deseja remover");
                            qnt = int.Parse(Console.ReadLine());
                            l.RemoverLivro(qnt);
                            Console.WriteLine("Livro removido com sucesso!");
                    break;
                    case 3: 
                            Console.WriteLine(l);
                    break;
                    case 4: 
                            Console.WriteLine("\tCerteza que deseja sair? [1-sim]/[2-não]");
                            loop = int.Parse(Console.ReadLine());
                    break;
                    default: 
                            Console.WriteLine("Digite uma opção válida!");
                    break;
                }
            }while(loop!=1);
        }
    }
}
