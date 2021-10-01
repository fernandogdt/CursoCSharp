using System;

namespace Exe03_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Opcao: ");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                int ent = int.Parse(Console.ReadLine());

                while (ent != 2002)
                {
                    Console.WriteLine("Senha invalida");

                    ent = int.Parse(Console.ReadLine());

                }
                Console.WriteLine("Acesso Permitido");
            }
            else
                if (opcao == 2)
            {

                string[] str = Console.ReadLine().Split(' ');

                int x = int.Parse(str[0]), y = int.Parse(str[1]);

                while (x != 0 && y != 0)
                {
                    coord(x, y);

                    str = Console.ReadLine().Split(' ');
                    x = int.Parse(str[0]); 
                    y = int.Parse(str[1]);

                }


            }
            else
            {

                int comb = int.Parse(Console.ReadLine());
                int alc =0, gas=0, dis=0;


                while (comb != 4)
                {
                    
                    
                    
                    switch (comb)
                    {
                        case 1:
                            alc++;
                            break;

                        case 2:
                            gas++;
                            break;
                        case 3:
                            dis = dis + 1;
                            break;
                        default:
                            break;
                    }

                    comb = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("MUITO OBRIGADO");
                Console.WriteLine("Alcool: " + alc);
                Console.WriteLine("Gasolina: {0}",gas );
                Console.WriteLine($"Diesel: {dis}");

            }


        }

        static void coord(int x, int y){

            if (x > 0 && y > 0)
                Console.WriteLine("primeiro");
            else
            if (x > 0 && y < 0)
                Console.WriteLine("quarto");
            else
            if ( x < 0 && y > 0)
                Console.WriteLine("segundo");
            else
            if ( x < 0 && y < 0)
                Console.WriteLine("terceiro");

        }

    }
}
