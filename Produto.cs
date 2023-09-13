using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudProduto
{
    internal class Produto
    {
        private static int proximoId = 1;

        // Propriedade para o ID do produto
        public int Id { get; set; }

        // Propriedade para o nome do produto
        public string? Nome { get; set; }

        // Propriedade para o preço do produto
        public decimal Preco { get; set; }

        // Construtor padrão
        public Produto()
        {
            Id = proximoId++;
            // Você pode inicializar valores padrão ou fazer outras ações no construtor, se necessário.
        }

        // Construtor personalizado que aceita valores para todos os atributos
        public Produto(string nome, decimal preco)
            : this()
        {
           
            Nome = nome;
            Preco = preco;
        }


        public override string ToString()
        {
            // Aqui você pode definir o formato de representação da string como desejar
            return $"\nID: {Id}\nNome: {Nome} \nPreço: {Preco:C} \n";
        }


    }
}
