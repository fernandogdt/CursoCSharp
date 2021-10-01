using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exe06_79
{
    class Program
    {
        static void Main(string[] args)
        {

            List <Employee> lista = new List<Employee>();
            Employee func;
            int id;
            string name;
            double salary;



            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                name = Console.ReadLine();

                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                func = new Employee(id, name, salary);

                lista.Add(func);
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            id = int.Parse(Console.ReadLine());


            Employee cod = lista.Find(z => z.Id == id);
            
            if (cod == null)
            { 
                Console.WriteLine("This id does not exist!");
            }
            else 
            { 
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cod.increasSalary(percentage);
            }

            Console.WriteLine("");
            Console.WriteLine("Updated list of employees:");

            foreach (Employee y in lista)
            {
                Console.WriteLine(y);
            }
        }
    }
}
