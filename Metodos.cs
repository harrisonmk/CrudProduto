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


        public void adicionar(Produto produto)
        {
            listaDeProdutos.Add(produto);
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


        // Método para remover um produto com base no ID
        public bool removerProdutoPorId(int id)
        {
            Produto? produtoParaRemover = listaDeProdutos.FirstOrDefault(p => p.Id == id);

            if (produtoParaRemover != null)
            {
                listaDeProdutos.Remove(produtoParaRemover);
                return true; // Produto removido com sucesso
            }
            else
            {
                return false; // Produto com o ID especificado não encontrado
            }
        }


        // Método para editar o nome do produto por ID
        public bool editarNomePorId(int id)
        {
           bool verifica = buscaProdutoPorId(id);

            Produto? produtoParaEditar = listaDeProdutos.FirstOrDefault(p => p.Id == id);

            if (verifica == true)
            {
                Console.Write("Digite o novo nome do produto: ");
                String? novoNomee = Console.ReadLine();
                produtoParaEditar.Nome = novoNomee;
                return true; // Nome do produto editado com sucesso
            }
            else
            {
                return false; // Produto com o ID especificado não encontrado
            }
        }


        // Método para remover um produto com base no ID
        public bool buscaProdutoPorId(int id)
        {
            Produto? produtoParaRemover = listaDeProdutos.FirstOrDefault(p => p.Id == id);

            if (produtoParaRemover != null)
            {
                
                return true; // Produto removido com sucesso
            }
            else
            {
                return false; // Produto com o ID especificado não encontrado
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
                        adicionar(leitura());


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

                        //Console.Write("Digite o novo nome do produto: ");
                        //String? novoNome = Console.ReadLine();

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
                // A entrada foi convertida com sucesso para um número double
            }
            else
            {
                Console.WriteLine("Valor inválido. Certifique-se de inserir um número válido.");
                // Aqui você pode adicionar lógica para lidar com a entrada inválida, se necessário.
            }

            return new Produto(nome, valor);
        }


    


    }


}