using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudProduto
{
    internal class Metodos
    {

        List<Produto> listaDeProdutos = new List<Produto>();



        public bool CadastrarProduto(Produto produto)
        {
            listaDeProdutos.Add(produto);

            
            if (listaDeProdutos.Count > 0)
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }


        public void listarProdutos()
        {
            if (listaDeProdutos.Count != 0)
            {
                foreach (var produto in listaDeProdutos)
                {
                    Console.WriteLine(produto.ToString());
                    Console.WriteLine("----------");
                }
            }
            else
            {
                Console.WriteLine("\nNenhum Produto Cadastrado!");
                Console.WriteLine("----------");
            }


        }


        
        public bool removerProdutoPorId(int id)
        {
            Produto? produtoParaRemover = listaDeProdutos.FirstOrDefault(p => p.Id == id);

            if (produtoParaRemover != null)
            {
                listaDeProdutos.Remove(produtoParaRemover);
                return true; 
            }
            else
            {
                return false; 
            }
        }


        
        public bool editarNomePorId(int id)
        {
           bool verifica = buscaProdutoPorId(id);

            Produto? produtoParaEditar = listaDeProdutos.FirstOrDefault(p => p.Id == id);

            if (verifica == true)
            {
                Console.Write("Digite o novo nome do produto: ");
                String? novoNomee = Console.ReadLine();
                produtoParaEditar.Nome = novoNomee;
                return true; 
            }
            else
            {
                return false; 
            }
        }


        
        public bool buscaProdutoPorId(int id)
        {
            Produto? produtoParaRemover = listaDeProdutos.FirstOrDefault(p => p.Id == id);

            if (produtoParaRemover != null)
            {
                
                return true; 
            }
            else
            {
                return false; 
            }
        }





        private void imprimeItensMenu()
        { 
           
            Console.WriteLine("\nDigite 1 para Cadastrar: ");
            Console.WriteLine("Digite 2 para Apagar um item: ");
            Console.WriteLine("Digite 3 para Editar um item: ");
            Console.WriteLine("Digite 4 para Listar: ");
            Console.WriteLine("Digite 0 para Sair.");
            Console.Write("Opcao: ");

        }



        public void menu()
        {

            int opcao;

            do
            {
                
               
                imprimeItensMenu();
                opcao = Convert.ToInt32(Console.ReadLine());
               

                switch (opcao)
                {
                    case 1:

                        
                        if(CadastrarProduto(leitura()) == true)
                        {
                            Console.WriteLine("\n -- Produto Cadastrado com Sucesso! --");
                        }
                        else
                        {
                            Console.WriteLine("\n -- Erro ao cadastrar Produto! --");
                            
                        }
                        

                        break;
                    case 2:
                        Console.Write("\nDigite o ID do produto para ser apagado: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        if (removerProdutoPorId(id) == true)
                        {
                            Console.WriteLine("\n -- Produto apagado com sucesso! --");
                        }
                        else
                        {
                            Console.WriteLine("\n-- Id do produto nao encontrado ou produto nao cadastrado --");
                        }
                       

                        break;
                    case 3:
                        Console.Write("\nDigite o ID do produto para ser Editado: ");
                        int id1 = Convert.ToInt32(Console.ReadLine());

                        

                        bool teste = editarNomePorId(id1);


                        if (teste == true)
                        {
                            Console.WriteLine("\n -- Nome do Produto alterado com sucesso! --");
                        }
                        else
                        {
                            Console.WriteLine("\n-- Id do produto nao encontrado ou produto nao cadastrado --");
                        }


                        break;
                    case 4:
                        listarProdutos();
                       
                        break;


                    case 0:

                        break;
                    default:
                        Console.WriteLine("\nOpção inválida.");
                        break;

                }

               
            } while (opcao != 0);
           

        }


        private Produto leitura()
        {

            String? nome;
            do
            {
                Console.Write("\nDigite o Nome do Produto: ");
                nome = Console.ReadLine();

                if (string.IsNullOrEmpty(nome))
                {
                    Console.WriteLine("Nome não pode ser vazio. Tente novamente.");
                }
            } while (string.IsNullOrEmpty(nome));

            Console.Write("Digite o valor do Produto: ");
            decimal valor;

            if (decimal.TryParse(Console.ReadLine(), out valor))
            {
                
            }
            else
            {
                Console.WriteLine("Valor inválido. Certifique-se de inserir um número válido.");
                
            }

            return new Produto(nome, valor);
        }


    


    }


}