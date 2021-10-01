using System;
using System.Globalization;

namespace Exe03_23
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Entre com seu nome completo:");
            String x = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double z = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] v = Console.ReadLine().Split(' ');

            string a = v[0];
            int b = int.Parse(v[1]);
            double c = double.Parse(v[2],CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c.ToString("F2",CultureInfo.InvariantCulture));


        }
    }
}
