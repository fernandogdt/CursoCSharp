using Exe10_133.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
namespace Exe10_133
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> lista = new List<Product>();

            Console.Write("Enter the number of products: ");
            int qtd = int.Parse(Console.ReadLine());
            ;
            for (int i = 1; i<=qtd; i++)
            {
                Console.WriteLine("Product #{0} data:", i);
                Console.Write("Common, used or imported (c/u/i)? ");
                string tipo = Console.ReadLine();
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Price: ");
                double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (tipo == "i")
                {
                    Console.Write("Customs fee: ");
                    double taxa = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    lista.Add(new ImportedProduct(nome, preco, taxa));
                }
                else 
                    if (tipo == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ") ;
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    lista.Add(new UsedProduct(nome, preco, data));
                }
                else
                {
                    lista.Add(new Product(nome, preco));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");

            foreach(Product x in lista)
            {
                Console.WriteLine(x.PriceTag());
            }



        }
    }
}
