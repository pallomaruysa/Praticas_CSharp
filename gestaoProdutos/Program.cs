using System;
using System.Collections.Generic;

namespace gestaoProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();


           items.Add(new Item { nomeProduto = "Bola", Quantidade = 5, valorProduto = 2 });
           items.Add(new Item { nomeProduto = "Boneca", Quantidade = 52, valorProduto = 8 });

            int stopLoop = 0 ;
            do
            {
                stopLoop = 1;

                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Sistema de Gestão de Estoque dos Produtos");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("\n\tMENU: ");
                Console.WriteLine("1- Cadastrar novo produto");
                Console.WriteLine("2- Adicionar a quantidade de produtos");
                Console.WriteLine("3- Listar todos os produtos");
                Console.WriteLine("4- Remover um produto");
                Console.WriteLine("5- Valor total em estoque de todos os produtos");
                Console.WriteLine("6- Inserir tipo do produto");
                Console.WriteLine("7- Sair do programa");
                    

                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do produto");
                        string nameProduct = Console.ReadLine();
                        Console.WriteLine("Digite a quantidade de produtos");
                        int quantityProduct = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor do produto");
                        double valueProduct = double.Parse(Console.ReadLine());
                        items.Add(new Item { nomeProduto = nameProduct, Quantidade = quantityProduct, valorProduto = valueProduct });
                        Console.WriteLine("Produto cadastrado com sucesso!");
                    break;
                    case 2:

                        string name = Console.ReadLine();
                        int quantity = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o produto que você deseja adicionar no estoque:");
                        Console.WriteLine("Digite a quantidade de produtos que você deseja:");
                        
                        foreach (Item item in items)
                        {
                            if (item.nomeProduto == name)
                            {
                                Console.WriteLine("Produto encontrado! nome: " + item.nomeProduto);
                                Console.WriteLine("Quantidade anterior: " + item.Quantidade);
                                item.Quantidade = item.Quantidade + quantity;
                                Console.WriteLine("Quantidade atual: " + item.Quantidade);
                                Console.WriteLine("Quantidade de produtos atualizada com sucesso!");
                            };
                        }
                    break;
                    case 3:
                        Console.WriteLine("LISTAGEM DE PRODUTOS");
                        foreach (Item item in items)
                        {
                            Console.WriteLine("______________");
                            Console.WriteLine("Produto: " + item.nomeProduto);
                            Console.WriteLine("Valor: " + item.valorProduto);
                            Console.WriteLine("Quantidade: " + item.Quantidade);
                            Console.WriteLine("Valor do estoque do produto: " + item.Total());
                            if(item.tipoProduto==null){
                                Console.WriteLine("______________");
                            }else{
                                Console.WriteLine("Tipo do produto: " + item.tipoProduto);
                                Console.WriteLine("______________");
                            }                         
                        }
                    break;
                    case 4:
                        Console.WriteLine("Digite o identificador do produto que você deseja apagar: ");
                        int value = int.Parse(Console.ReadLine());
                        items.RemoveAt(value);
                    break;
                    case 5:
                            Console.WriteLine("Valor total do estoque: ");
                            double valorEstoqueTotal = 0;
                            foreach (Item item in items)
                            {
                                valorEstoqueTotal += item.Total();
                            }

                            Console.WriteLine("Valor total do estoque: " + valorEstoqueTotal);
                    break;

                    case 6:
                        Console.WriteLine("Digite o nome do produto que você deseja inserir a tipagem: ");
                        string productType = Console.ReadLine();
                        foreach (Item item in items)
                        {
                            if (item.nomeProduto == productType)
                            {
                                item.tipoProduto = item.TipoProduto();
                                Console.WriteLine("Tipo: " + item.tipoProduto);
                            }
                        }
                        Console.WriteLine("Tipo do produto cadastrado com sucesso!");

                    break;
                    case 7:
                        stopLoop = 0;
                    break;
                }

            } while (stopLoop != 0);




        }
    }
}
