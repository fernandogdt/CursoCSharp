using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe10_137.Entidades
{
    public abstract class Contribuinte
    {

        public string Nome { get; set; } 
        public double Renda { get; set; }

        public Contribuinte (string nome, double renda)
        {
            Nome = nome;
            Renda = renda;
        }

        public abstract double Calculo();

        public override string ToString()
        {
            return Nome + ": $ " + Calculo().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
