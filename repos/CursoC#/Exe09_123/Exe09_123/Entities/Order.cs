using Exe09_123.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe09_123.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; } = new OrderStatus();
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Client Client { get; set; }

       



        public Order(OrderStatus status, string nome, string email, DateTime data)
        {

           Client = new Client();
            
            Moment = DateTime.Now;
            Status = status;
            Client.Name = nome;
            Client.Email = email;
            Client.BirthDate = data;
        }


        public void addItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void removeItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double total()
        {
            double soma = 0;

            foreach (OrderItem n in Items)
            {
                soma = soma + n.subTotal();
            }

            return soma;
        }

        public override string ToString()
        {


            StringBuilder stb = new StringBuilder();
            Console.WriteLine();
            stb.AppendLine("ORDER SUMMARY:");
            stb.AppendLine("Order moment: " + Moment);
            stb.AppendLine("Order status: " + Status);
            stb.AppendLine("Client: " + Client.Name + " (" + Client.BirthDate.ToString("dd/MM/yyyy") + ") - " + Client.Email);
            stb.AppendLine("Order items: ");


            foreach (OrderItem x in Items)
            {

                double sub = x.subTotal();

                stb.AppendLine(x.Product.Name + ", $" + x.Product.Price.ToString("F2", CultureInfo.InvariantCulture) +
                                    ", Quantity: " + x.Quantity + ", Subtotal: $" +
                                    sub.ToString("F2", CultureInfo.InvariantCulture));
            }

            stb.AppendLine("Total price: $" + total().ToString("F2", CultureInfo.InvariantCulture));


            return stb.ToString();
        }
    }
}