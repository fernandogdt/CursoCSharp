using Exe10_131.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exe10_131
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee>  lista = new List<Employee>();


            Console.Write("Enter the number of employees: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                string s = Console.ReadLine();
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Hours: ");
                int hora = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (s == "y")
                {
                    Console.Write("Additional charge:");
                    double adicao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    OutsourcedEmployee terceiro = new OutsourcedEmployee(nome, hora, valor, adicao);
                    lista.Add(terceiro);
                }
                else
                {
                    Employee empregado = new Employee(nome, hora, valor);
                    lista.Add(empregado);
                }

            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");

            foreach (Employee k in lista)
            {
                Console.WriteLine(k);
            }


        }
    }
}
