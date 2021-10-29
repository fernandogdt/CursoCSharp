using System;
using System.Globalization;

namespace Exe10_133.Entidades
{
    public class UsedProduct : Product
    {

        public DateTime ManufactureDate { get; set; } 

        public UsedProduct (string nome, double preco, DateTime data) : base (nome, preco)
        {
            ManufactureDate = data;
        }

        public override string PriceTag()
        { 
            return Name +" (used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture) +
                    " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }

       

    }
}
