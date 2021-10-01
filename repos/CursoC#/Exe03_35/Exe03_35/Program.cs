using System;
using System.Globalization;

namespace Exe03_35
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.Write("Opção: ");
            int opcao = int.Parse(Console.ReadLine());

            while (opcao != 99)
            {
                if (opcao == 1)
                {
                    int x = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= x; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Console.WriteLine(i);
                        }
                    }


                }
                else
                    if (opcao == 2)
                {
                    int vin = 0;
                    int vout = 0;
                    int x = int.Parse(Console.ReadLine());

                    for (int i = 0; i < x; i++)
                    {
                        int y = int.Parse(Console.ReadLine());

                        if (y >= 10 && y <= 20)
                        {
                            vin++;
                        }
                        else
                            vout++;
                    }

                    Console.WriteLine(vin + " in");
                    Console.WriteLine(vout + " out");

                }
                else
                    if (opcao == 3)
                {
                    double n1, n2, n3;
                    double media;
                    int x = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= x; i++)
                    {

                        string[] vet = Console.ReadLine().Split(' ');

                        n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                        n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                        n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                        media = (n1 * 2 + n2 * 3 + n3 * 5) / 10;

                        Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

                    }
                }
                else
                    if (opcao == 4)
                {
                    int x = int.Parse(Console.ReadLine());
                    double res;
                    for (int i = 0; i < x; i++)
                    {
                        String[] vet = Console.ReadLine().Split(' ');
                        double n0 = double.Parse(vet[0]);
                        double n1 = double.Parse(vet[1]);

                        if (n1 == 0)
                        {
                            Console.WriteLine("divisao impossivel");
                        }
                        else
                        {
                            res = n0 / n1;
                            Console.WriteLine(res.ToString("F1",CultureInfo.InvariantCulture));
                        }
                    }
                }
                else
                if (opcao == 5)
                {
                    int x = int.Parse(Console.ReadLine());
                    int fat = x;

                    if (fat != 0)
                    {


                        for (int i = x - 1; i >= 1; i--)
                        {
                            fat = fat * i;
                        }
                    }
                    else
                        fat = 1;

                    Console.WriteLine(fat);

                }
                else
                if (opcao == 6)
                {
                    int x = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= x; i++)
                    {
                        if (x % i == 0)
                        {
                            Console.WriteLine(i);
                        }

                    }
                }
                else
                if (opcao == 7)
                {

                    int x = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= x; i++)
                    {
                        Console.WriteLine(i + " " + i*i + " " + i*i*i);



                    }


                }

                Console.Write("Opção: ");
                opcao = int.Parse(Console.ReadLine());
            }



        }
    }
}
