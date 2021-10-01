using System;
using System.Globalization;

namespace Exe04_45b
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario fun = new Funcionario();
            double perc = 0;
            Console.Write("Nome: ");

            fun.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            fun.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            fun.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");

            Console.WriteLine("Funcionario: " + fun.Nome + ", $ " + fun.SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("");

            Console.Write("Digite a porcentagem para aumentar o salário: ");

            //perc = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            fun.AumentarSalario(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
            fun.AumentarSalario(perc);
            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: " + fun.Nome + ", $ " + fun.SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
