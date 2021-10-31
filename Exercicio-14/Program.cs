using System.Globalization;
using System;
using System.Collections;

namespace Exercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList listaProduto = new ArrayList();
            int escolha;
            
            do{
                Console.WriteLine("\nMENU: ");
                Console.WriteLine("1: Cadastrar Novo Produto");
                Console.WriteLine("2: Alterar Produto");                
                Console.WriteLine("3: Remover Produto");
                Console.WriteLine("4: Vizualizar Lista de Produtos");
                Console.WriteLine("5: Sair \n");

                escolha = int.Parse(Console.ReadLine());

                Produto p = new Produto();
                
                switch(escolha){
                    case 1:                    
                            Console.WriteLine("\nDigite os dados do produto\n");
                            Console.WriteLine("Código: ");
                            p.Codigo = int.Parse(Console.ReadLine());
                            Console.WriteLine("Nome: ");
                            p.Nome = Console.ReadLine();
                            Console.WriteLine("Preço: ");
                            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.WriteLine("Quantidade no estoque: ");
                            p.Quantidade = int.Parse(Console.ReadLine());
                            Console.WriteLine("------------------------------------------------------");
                            listaProduto.Add(p);
                    break;
                    
                    case 2: 
                            Console.WriteLine("\n1: Adicionar quantidade do produto no estoque");
                            Console.WriteLine("2: Remover quantidade do produto no estoque");

                            int escolhaAcao = int.Parse(Console.ReadLine());

                            switch(escolhaAcao){
                                case 1: 
                                        Console.WriteLine("Digite o ID do produto a ser modificado: ");
                                        int id1 = int.Parse(Console.ReadLine());
                                        listaProduto.LastIndexOf(id1);
                                        Console.WriteLine("Digite a quantidade de produtos a ser adicionado: ");
                                        p.AdicionarProduto(int.Parse(Console.ReadLine()));
                                break;
                                case 2:
                                        Console.WriteLine("Digite o ID do produto a ser modificado: ");
                                        int id2 = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Digite a quantidade de produtos a ser removido: ");
                                        p.RemoverProduto(int.Parse(Console.ReadLine()));
                                break;
                            }
                    break;

                    case 3:
                            Console.WriteLine("\nDigite o código do produto a ser removido");
                            int id = int.Parse(Console.ReadLine());
                            
                            for(int i=0; i< listaProduto.Count; i++){
                                if(id == p.Codigo){
                                    listaProduto.RemoveAt(id);    
                                    Console.WriteLine("Código do produto removido com sucesso \n");      
                                }
                                else{
                                    Console.WriteLine("Código do produto inexistente");
                                }
                            }
                        break;
                            
                    case 4:
                            foreach(Produto i in listaProduto){
                                    Console.WriteLine("\nDados do Produto: "+i);
                            }                            
                    break;

                    case 5: 
                             Console.WriteLine("Saindo da Operação");
                    break;

                    default:
                            Console.WriteLine("Opção inválida! Digite um valor que esteja no menu");
                    break;
                            
                }

            } while(escolha != 5);
        }
            
    }
}
