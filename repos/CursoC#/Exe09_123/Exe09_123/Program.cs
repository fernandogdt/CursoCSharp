using Exe09_123.Entities;
using Exe09_123.Entities.Enum;
using System;
using System.Globalization;

namespace Exe09_123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data: ");

            Console.Write("Name: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("How many items to this order? ");
            int qtd = int.Parse(Console.ReadLine());

            Order ordem = new Order(status, nome, email, data);

            string nmproduto;
            double vlproduto;
            int qtproduto;

            OrderItem item;

            for ( int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");

                Console.Write("Product name: ");
                nmproduto = Console.ReadLine();
                Console.Write("Product price: ");
                vlproduto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Quantity: " );
                qtproduto = int.Parse(Console.ReadLine());

                item = new OrderItem(qtproduto,vlproduto, nmproduto);

                ordem.addItem(item);

            }

            

            Console.WriteLine(ordem);
           
        }
    }
}
