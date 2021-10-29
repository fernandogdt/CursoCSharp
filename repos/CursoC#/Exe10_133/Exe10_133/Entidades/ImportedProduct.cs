using System.Globalization;

namespace Exe10_133.Entidades
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }


        public ImportedProduct(string nome, double preco, double taxa)
            : base(nome,preco)
        {
            CustomsFee = taxa;
        }


        public override string PriceTag()
        {
           // return "{0} $ {1} (Customs fee: $ {2}" ,  Name; totalPrice().ToString("F2", CultureInfo.InvariantCulture); CustomsFee.ToString("F2", CultureInfo.InvariantCulture) ;

            return $"{Name} $ { totalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }


        public double totalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
