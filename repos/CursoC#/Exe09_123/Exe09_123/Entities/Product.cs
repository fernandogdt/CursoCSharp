using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe09_123.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        
        public Product ()
        {

        }

        public Product(string nome, double preco)
        {
            Name = nome;
            Price = preco;
        }
    }
}
