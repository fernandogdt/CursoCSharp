
using Exe10_136.Entidades.Enum;

namespace Exe10_136.Entidades
{
    public class Rectangle : Shape
    {

        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle (Color cor, double largura, double altura) : base(cor)
        {
            Width = largura;
            Height = altura;
        }

        public override double Area()
        {
            return Width * Height;
               
        }
        
        

    }
}
