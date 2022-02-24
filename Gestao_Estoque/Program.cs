using System;
using System.Collections;
using System.Globalization;

namespace Gestao_Estoque
{
    class Program
    {
        public static void Main(string[] args)
        {
            int escolha, escolha2, qtd, stopLoop=1;
            ArrayList listaProdutos = new ArrayList();

            do{
                stopLoop=1;
                
                Produto p1 = new Produto();

                Console.WriteLine("\t\t\t\t\tSistema de Gestão de Estoque dos Produtos");
                p1.tipoProduto();

                Console.WriteLine("\n\tMENU: ");
                Console.WriteLine("1- LISTAR PRODUTOS");               
                Console.WriteLine("2- CADASTRAR PRODUTO");               
                Console.WriteLine("3- REMOVER PRODUTO");               
                Console.WriteLine("4- SAIR");
                escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1: 
                            
                    break;
                    case 2:
                            Console.WriteLine("\nDigite o nome do produto para cadastro");
                            p1.nomeProduto = Console.ReadLine();
                            Console.WriteLine("Digite o valor do produto para cadastro");
                            p1.valorProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.WriteLine("Digite a quantidade de produto para cadastro: ");
                            p1.Quantidade = int.Parse(Console.ReadLine());
                            Console.WriteLine("\nDados do produto cadastrado: "+p1); 

                            while(stopLoop==1){
                                Console.WriteLine("\n1- ADICIONAR PRODUTO");
                                Console.WriteLine("2- REMOVER PRODUTO");
                                Console.WriteLine("3- VOLTAR AO MENU PRINCIPAL");
                                escolha2 = int.Parse(Console.ReadLine());

                                switch (escolha2)
                                {
                                    case 1:
                                            Console.WriteLine("\nDigite a quantidade de produtos a ser adicionado: ");
                                            qtd = int.Parse(Console.ReadLine());
                                            p1.AdicaoProdutos(qtd);    
                                            Console.WriteLine("\nDados atualizados: "+p1);
                                    break;

                                    case 2:
                                            Console.WriteLine("\nDigite a quantidade de produtos a ser removido: "); 
                                            qtd = int.Parse(Console.ReadLine());
                                            p1.RemocaoProdutos(qtd);
                                            Console.WriteLine("\nDados atualizados: "+p1); 
                                    break;
                                    case 3:
                                            stopLoop = 2;
                                    break;
                                    default:
                                            Console.WriteLine("\nOpção inválida! Escolha um valor existente no menu!");
                                    break;
                                }
                            }                                                      
                    break;

                    case 4:
                            Console.WriteLine("\nPara parar o loop digite 0. Caso queira voltar ao menu digite 1");
                            stopLoop = int.Parse(Console.ReadLine());
                    break;
                    
                    default:
                            Console.WriteLine("Opção inválida! Escolha um valor existente no menu!");
                    break;
                }
            }while(stopLoop!=0);

        }
    }
}