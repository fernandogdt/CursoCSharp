using System;


class minhaClasse
{
    static void Main(string[] args)
    {

        string[] entrada = Console.ReadLine().Split(" ");


        double H = double.Parse(entrada[0]);
        double P = double.Parse(entrada[1]);


        double media = H / P;
        string media2 = media.ToString("N2");

        //    Console.WriteLine(Math.Round(media, 2));
     //   Console.WriteLine(Math.Truncate(media * 100 ) / 100);
        Console.WriteLine(media2);

    }
}