using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe09_123.Entities
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, double price, string nome)
        {
            Product = new Product();

            Quantity = quantity;
            Price = price;
            Product.Name = nome;
            Product.Price = price;
        }

        public double subTotal()
        {
            return Quantity * Price;
        }
    }
}
