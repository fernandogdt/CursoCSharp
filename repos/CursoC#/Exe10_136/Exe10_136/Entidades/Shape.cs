using System;

using Exe10_136.Entidades.Enum;

namespace Exe10_136.Entidades
{
    public abstract class Shape
    {

        public Color Color { get; set; }

        public Shape (Color cor)
        {
            Color = cor;
        }

        public abstract double Area();

    }
}
