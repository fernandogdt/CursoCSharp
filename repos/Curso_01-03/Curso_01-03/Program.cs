using System;

namespace Curso_01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double z;
            string x = Console.ReadLine();
            string h = Console.ReadLine();

            string[] words1 = x.Split(' ');
            string[] words2 = h.Split(' ');

        //    Console.WriteLine("Hello World!" + x);

            z = Int16.Parse(words1[1]) * double.Parse(words1[2]) +
                Int16.Parse(words2[1]) * double.Parse(words2[2]);
            Console.WriteLine("VALOR A PAGAR: R$ " +  z.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture));  // --e("VALOR A PAGAR: R$ " + z);


        }
    }
}
