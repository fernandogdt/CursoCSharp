using System;

namespace Exe06_81
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] z = Console.ReadLine().Split(' ');
            int x = int.Parse(z[0]);
            int y = int.Parse(z[1]);

            int[,] mat = new int[x,y];
            string[] linha;
          //  Console.WriteLine(mat.GetLength(0));
          //  Console.WriteLine(mat.GetLength(1));

            for (int i = 0; i < x; i++)
            {
                 linha = Console.ReadLine().Split(' ');

                for (int j = 0; j < y; j++)
                {
                    mat[i, j] = int.Parse(linha[j]);
                }
            }
            
            int h = int.Parse(Console.ReadLine());

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                   
                    if (h == mat[i, j])
                    {
                        Console.WriteLine("Position {0},{1}:",i,j );

                        if (j > 0)
                           Console.WriteLine("Left: " + mat[i,j-1]);
                        if (j < mat.GetLength(1)-1)
                            Console.WriteLine($"Right: {mat[i,j+1]}" );
                        if (i > 0)
                            Console.WriteLine("Up: " + mat[i-1,j] );
                        if (i < mat.GetLength(0) - 1){
                            Console.WriteLine("Down: " + mat[i+1,j]);
                        }

                    }
                }
            }
        }
    }
}
