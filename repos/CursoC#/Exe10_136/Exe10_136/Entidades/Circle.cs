using Exe10_136.Entidades.Enum;
using System;

namespace Exe10_136.Entidades
{
    public class Circle : Shape
    {

        public double Radius { get; set; }

        public Circle (Color cor, double raio) : base(cor)
        {
            Radius = raio;
        }

        public override double Area()
        {
          
            return Math.PI * Math.Pow(Radius, 2);
        }


    }
}
