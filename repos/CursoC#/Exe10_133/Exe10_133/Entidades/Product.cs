using System.Globalization;

namespace Exe10_133.Entidades
{
    public class Product
    {

        public string Name { get; set; }
        public double Price { get; set; }

        public Product (string nome, double preco)
        {
            Name = nome;
            Price = preco;
        }

        public virtual string PriceTag()
        {
            return Name + " $ " + Price.ToString("F2",CultureInfo.InvariantCulture);
        }



    }
}
