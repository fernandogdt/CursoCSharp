using System;

namespace Exe06_80
{
    class Program
    {
        static void Main(string[] args)
        {


            int neg = 0;

            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];
            //    int [] linha = int.Parse(Console.ReadLine().Split(" "));
            
            for (int i = 0; i < n; i++)
            {
                string[] linha = Console.ReadLine().Split(" ");
                for (int j = 0; j< n; j++)
                {
                    matriz[i,j] = int.Parse(linha[j]);
                }

            }
            /*
            foreach (int x in matriz)
            {
                Console.WriteLine(x);
            }
            */

            Console.WriteLine("Main diagonal:");
            for (int i = 0;i < n;i++)
            {
               for (int j = 0; j < n; j++)
                {
                    if ( i == j)
                        Console.Write(matriz[i,j] + " ");

                    if (matriz[i, j] < 0)
                        neg++;
                }

            }

            Console.WriteLine();
             Console.Write("Negative numbers = " + neg);
            // Console.WriteLine(matriz.Rank);

            //for (int i = 0; i < matriz.)



            //Console.WriteLine("Hello World!");
        }
    }
}
