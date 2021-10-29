using System;
using System.Collections.Generic;
using System.Globalization;
using Exe10_136.Entidades;
using Exe10_136.Entidades.Enum;
namespace Exe10_136
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> lista = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int forma = int.Parse(Console.ReadLine());

            for (int i = 1; i <= forma; i++)
            {
                Console.WriteLine("Shape #{0} data:", i);
                Console.Write("Rectangle or Circle (r/c)? ");
                string tipo = Console.ReadLine();

                Console.Write("Color (Black/Blue/Red): ");
                //  string cor = (Console.ReadLine());
                Color cor = Enum.Parse<Color>(Console.ReadLine());

                if (tipo == "r")
                {
                    Console.Write("Width: ");
                    double largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    lista.Add(new Rectangle(cor, largura, altura));
                }
                else
                    if (tipo == "c")
                {
                    Console.Write("Radius: ");
                    double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    lista.Add(new Circle(cor, raio));

                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");

            foreach(Shape y in lista)
            {
                Console.WriteLine(y.Area().ToString("F2",CultureInfo.InvariantCulture)); 
            }

        }
    }
}
