using System;

namespace Exe06_71
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Inquilino[] quarto = new Inquilino[10];


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Aluguel #" + i + ":");
                Console.Write("Nome: " );
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int numero = int.Parse(Console.ReadLine());

                //  quarto[numero] = new Inquilino { Nome = nome, Email = email };
                quarto[numero] = new Inquilino ( nome, email );
                Console.WriteLine("");
            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (quarto[i] != null)
                {
                    //  Console.WriteLine(i + ": " + quarto[i].Nome + ", " + quarto[i].Email);
                    Console.WriteLine(i + "" +quarto[i]);
                  
                }


            }
                
                
        }
    }
}
