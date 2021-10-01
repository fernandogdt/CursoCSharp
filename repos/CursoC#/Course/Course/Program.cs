using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {


            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;


            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1 + ", cujo preço é $ " + preco1.ToString("F2"));
            Console.WriteLine("{0}, cujo preco é $ {1:F2}",produto2,preco2);
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}" );
            Console.WriteLine("Arredondado (três casas decimais): {0:F3}",medida);
            Console.WriteLine("Separador decimal invariant culture: "+ medida.ToString("F3",CultureInfo.InvariantCulture));

            /***
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            byte x = 128;
            long y = 2147483648L;
            long z = 2147483648;
            float x1 = float.MinValue;
            decimal x2 = decimal.MaxValue;
            float x3 = 45.8546848f;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x3.ToString("F3"));
            Console.WriteLine(x3.ToString("F3",CultureInfo.InvariantCulture));
            ***/
        }
    }
}
