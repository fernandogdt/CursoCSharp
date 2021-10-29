using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe10_137.Entidades
{
    public class PessoaFisica : Contribuinte
    {
        public double Saude { get; set; }


        public PessoaFisica (string nome, double renda, double saude) : base (nome, renda)
        {
            Saude = saude;
        }

        public override double Calculo()
        {
          //  double imposto = 0;

            if (Renda < 20000)
            {
                return Renda * 0.15 - (Saude * 0.5);
            }
            else
            {
                return Renda * 0.25 - (Saude * 0.5);
            }
            
             
        }

        


    }
}
