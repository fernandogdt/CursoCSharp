using System;
using System.Globalization;

namespace Exe03_29
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Opcao: ");
            int opcao = int.Parse(Console.ReadLine());

            while (opcao != 99)
            {

                if (opcao == 1)
                {
                    int x = int.Parse(Console.ReadLine());

                    if (x < 0)
                    {
                        Console.WriteLine("NEGATIVO");
                    }
                    else
                        Console.WriteLine("NAO NEGATIVO");


                }
                else
                    if (opcao == 2)
                {
                    int x = int.Parse(Console.ReadLine());

                    if (x % 2 == 0)
                    {
                        Console.WriteLine("PAR");
                    }
                    else
                    {
                        Console.WriteLine("IMPAR");
                    }

                }
                else
                    if (opcao == 3)
                {

                    string[] z = Console.ReadLine().Split(' ');

                    int x = int.Parse(z[0]);
                    int y = int.Parse(z[1]);

                    if ((x % y == 0) || (y % x) == 0)
                    {
                        Console.WriteLine("Sao Multiplos");
                    }
                    else
                    {
                        Console.WriteLine("Nao sao Multiplos");
                    }
                }
                else
                    if (opcao == 4)
                {
                    string[] z = Console.ReadLine().Split(' ');

                    int x = int.Parse(z[0]);
                    int y = int.Parse(z[1]);
                    int w = 0;
                    if (x > y)
                    {
                        w = y + 24 - x;

                    }
                    else
                    if (x < y)
                    {
                        w = y - x;
                    }
                    else
                    {
                        w = 24;
                    }

                    Console.WriteLine("O JOGO DUROU {0} HORAS(S)", w);

                }
                else
                        if (opcao == 5)
                {

                    string[] k = Console.ReadLine().Split(' ');

                    int x = int.Parse(k[0]);
                    int y = int.Parse(k[1]);

                    double z = 0;

                    if (x == 1)
                        z = 4;
                    else if (x == 2)
                        z = 4.5;
                    else if (x == 3)
                        z = 5;
                    else if (x == 4)
                        z = 2;
                    else if (x == 5)
                        z = 1.5;

                    double preco = y * z;

                    Console.WriteLine("Total: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));
                }
                else
                        if (opcao == 6)
                {
                    double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine(x);

                    if (x < 0)
                        Console.WriteLine("Fora do Intervalo");
                    else
                    if (x <= 25.00)
                        Console.WriteLine("Intervalo: [0,25]");
                    else
                        if (x <= 50)
                        Console.WriteLine("Intervalo: (25,50]");
                    else
                            if (x <= 75)
                        Console.WriteLine("Intervalo: (50,75]");
                    else
                                if (x <= 100)
                        Console.WriteLine("Intervalo: (75,100]");
                    else
                        Console.WriteLine("Fora do Intervalo");


                }
                else
                      if (opcao == 7)
                {

                    string[] array = Console.ReadLine().Split(' ');
                    double x = double.Parse(array[0], CultureInfo.InvariantCulture);
                    double y = double.Parse(array[1], CultureInfo.InvariantCulture);

                    if (x > 0 && y > 0)
                    {
                        Console.WriteLine("Q1");
                    }
                    else
                        if (x > 0 && y < 0)
                    {
                        Console.WriteLine("Q4");
                    }
                    else
                        if (x < 0 && y > 0)
                    {
                        Console.WriteLine("Q2");
                    }
                    else
                        if (x < 0 && y < 0)
                        Console.WriteLine("Q3");
                    else
                            if (x == 0 && y == 0)
                    {
                        Console.WriteLine("Origem");
                    }
                    else
                    if (x == 0)
                        Console.WriteLine("Eixo X");
                    else
                    if (y == 0)
                    {
                        Console.WriteLine("Eixo Y");
                    }




                }
                else if (opcao == 8)
                {

                    float salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    float imposto = 0;

                    float f1 = 2000, f2 = 3000, f3 = 4500;


                    if (salario <= f1)
                    {
                        Console.WriteLine("Isento");
                    }
                    else
                        if (salario <= f2)
                    {
                        imposto = (salario - f1) * 8 / 100;
                        Console.WriteLine("R$ " + imposto.ToString("F2",CultureInfo.InvariantCulture));
                    }
                    else
                    if (salario <= f3)
                    {
                        imposto = (float)(((salario - f2) * 18 / 100) + (999.99 * 8 / 100));
                        Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
                    }
                    else
                    {
                        imposto = (salario - f3) * 28 / 100;
                        Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));

                        imposto = imposto + (float) (1499.99 * 18 / 100);
                        Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));

                        imposto =  imposto + (float)(999.99 * 8 / 100);
                        Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
                    }





                }

                Console.Write("Opcao: ");
                opcao = int.Parse(Console.ReadLine());
            }
            // Console.WriteLine("Hello World!");



        }
    }
}
