using System;
using System.Globalization;

namespace Exe03_24
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Opcao: ");
            char opcao = char.Parse(Console.ReadLine());

            if (opcao == '1')
            {
                int z;

                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                z = x + y;
                Console.WriteLine($"SOMA = {z}");
            }
            else 
                if (opcao == '2')
            {
                double pi = 3.14159;

                Console.WriteLine("Entrada:");
                double r = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                double a = pi * (r * r);

                Console.WriteLine("Saída: ");
                Console.WriteLine("A= " + a.ToString("F4",CultureInfo.InvariantCulture));

            }
            else
                if(opcao == '3')
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                int d = int.Parse(Console.ReadLine());

                int dif = a * b - c * d;

                Console.WriteLine("DIFERENCA = " + dif);
            }
            else
                if (opcao == '4')
            {
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());
                float z = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                float salario = y * z;

                Console.WriteLine("NUMBER = {0}", x);
                Console.WriteLine($"SALARY = U$ {salario.ToString("F2",CultureInfo.InvariantCulture)}");
            }
            else
                if (opcao =='5')
            {
                string[] x = Console.ReadLine().Split(' ');
                string[] y = Console.ReadLine().Split(' ');

                double a = int.Parse(x[1]) * double.Parse(x[2],CultureInfo.InvariantCulture);
                double b = int.Parse(y[1]) * double.Parse(y[2], CultureInfo.InvariantCulture);

                double total;

                total = a + b;

                Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture)); 
            }
            else 
                if (opcao == '6')
            {

                string[] x = (Console.ReadLine().Split(' '));

                double A, B, C;

                A = double.Parse(x[0], CultureInfo.InvariantCulture);
                B = double.Parse(x[1], CultureInfo.InvariantCulture);
                C = double.Parse(x[2], CultureInfo.InvariantCulture);


                double tri, cir, tra, qua, ret, pi;
                pi = 3.14159;

                tri = A * C / 2;
                cir = pi * C * C;
                tra = (A + B) * C / 2;
                qua = B * B;
                ret = A * B;

                Console.WriteLine("TRIANGULO: " + tri.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("CIRCULO: " + cir.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("TRAPEZIO: " + tra.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("QUADRADO: " + qua.ToString("F3",CultureInfo.InvariantCulture));
                Console.WriteLine("RETANGULO: " + ret.ToString("F3",CultureInfo.InvariantCulture));





            }








        }
    }
}
