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

       
        public int Id { get; set; }

        
        public string? Nome { get; set; }

        
        public decimal Preco { get; set; }

        
        public Produto()
        {
            Id = proximoId++;
            
        }

        
        public Produto(string nome, decimal preco)
            : this()
        {
           
            Nome = nome;
            Preco = preco;
        }


        public override string ToString()
        {
            
            return $"\nID: {Id}\nNome: {Nome} \nPreço: {Preco:C} \n";
        }


    }
}
