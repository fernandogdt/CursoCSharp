using System;
using System.Collections.Generic;
using System.Globalization;

using Exe09_119.Entidades;
using Exe09_119.Enum;
namespace Exe09_119
{
    class Program
    {
        static void Main(string[] args)
        {
              
            string setor;
            string nome;
            string nivel;
            double salarioBase;
            double total = 0;
            int qtcontrato;
            Worker funcionario;
            WorkerLevel level;
            Department departamento;

            DateTime periodo;
            double valor;
            int duracao;
            HourContract contrato;

            List<HourContract> lista = new List<HourContract>();


            Console.Write("Enter department's name: ");
            setor = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            nome = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            nivel = Console.ReadLine();
            Console.Write("Base salary: ");
            salarioBase = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("How many contracts to this worker? ");
            qtcontrato = int.Parse(Console.ReadLine());

            level = Enum.WorkerLevel.Parse<WorkerLevel>(nivel.ToUpper()) ;

            departamento = new Department(setor);

            funcionario = new Worker(nome, level, salarioBase, departamento);

            
            for (int i = 1; i <= qtcontrato; i++)
            {
                Console.WriteLine("Enter #{0} contract data:",i);
                Console.Write("Date (DD/MM/YYYY): ");
                periodo = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                duracao = int.Parse(Console.ReadLine());

                contrato = new HourContract(periodo, valor, duracao);
                funcionario.AddContract(contrato);
                Console.WriteLine();
              
            }
            
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            DateTime apuracao = DateTime.Parse(Console.ReadLine());


            total =  funcionario.Income(apuracao.Year, apuracao.Month);

            Console.WriteLine("Name: " + funcionario.Name);
            Console.WriteLine("Department: " + funcionario.Department.Name);
            Console.WriteLine("Income for " + apuracao.ToString("MM/yyyy") + ": " +  total.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
