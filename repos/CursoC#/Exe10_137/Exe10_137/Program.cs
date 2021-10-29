using Exe10_137.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exe10_137
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuinte> lista = new List<Contribuinte>();


            Console.Write("Enter the nummber of tax payers: ");
            int pag = int.Parse(Console.ReadLine());

            for (int i = 1; i <= pag; i++)
            {
                Console.WriteLine("Tax payer #{0} data: " , i);

                Console.Write("Individual or company (i/c)?" );

                string tipo = Console.ReadLine();
                Console.Write("Name: ");
                string nome = Console.ReadLine();

                Console.Write("Anual income: ");
                double renda = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                
                if (tipo == "i")
                {
                    Console.Write("Health expenditures: ");
                    double saude = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    lista.Add(new PessoaFisica(nome, renda, saude));
                }
                else 
                if (tipo == "c")
                {
                    Console.Write("Number of employees: ");
                    int empregados = int.Parse(Console.ReadLine());
                    lista.Add(new PessoaJuridica(nome, renda, empregados));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double soma = 0;
            foreach(Contribuinte x in lista)
            {
                Console.WriteLine(x);

                soma += x.Calculo(); ;

            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
