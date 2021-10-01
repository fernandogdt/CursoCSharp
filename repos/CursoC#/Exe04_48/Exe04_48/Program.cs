using System;
using System.Globalization;
namespace Exe04_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Valor a ser pago em reais = " + ConversorDeMoeda.CalculaMoeda(x,y).ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
