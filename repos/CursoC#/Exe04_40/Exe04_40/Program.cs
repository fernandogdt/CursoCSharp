using System;
using System.Globalization;
namespace Exe04_40
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Opcao: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {

                case 1:

                    Pessoa x;

                    x = new Pessoa();

                    Console.WriteLine("Dados da primeira pessoa: ");
                    Console.Write("Nome: ");
                    x.Nome = Console.ReadLine();
                    Console.Write("Idade: ");
                    x.Idade = int.Parse(Console.ReadLine());

                    Pessoa y = new Pessoa();

                    Console.WriteLine("Dados da segunda pessoa: ");
                    Console.Write("Nome: ");
                    y.Nome = Console.ReadLine();
                    Console.Write("Idade: ");
                    y.Idade = int.Parse(Console.ReadLine());

                    if (x.Idade > y.Idade)
                    {
                        Console.WriteLine("Pessoa mais velha: " + x.Nome);
                    }
                    else
                        Console.WriteLine("Pessoa mais velha: " + y.Nome);
                    break;

                case 2:

                    Funcionario a, b;

                    a = new Funcionario();
                    b = new Funcionario();

                    double media;

                    Console.WriteLine("Dados do primeiro funcionário:");
                    Console.Write("Nome: ");
                    a.Nome = Console.ReadLine();
                    Console.Write("Salário: ");
                    a.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    Console.WriteLine("Dados do segundo funcionário:");
                    Console.Write("Nome: ");
                    b.Nome = Console.ReadLine();
                    Console.Write("Salário: ");
                    b.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    media = (a.Salario + b.Salario) / 2;

                    Console.Write("Salario médio = " + media.ToString("F2",CultureInfo.InvariantCulture));



                    break;

                default:
                    break;

            }

        }



    }
}
