using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe10_137.Entidades
{
    public class PessoaJuridica: Contribuinte
    {

        public double Funcionarios { get; set; }


        public PessoaJuridica (string nome, double renda, int funcionarios) : base (nome, renda)
        {
            Funcionarios = funcionarios;
        }

        public override double Calculo()
        {
            if (Funcionarios <= 10)
            {
                return Renda * 0.16;
            }
            else
                return Renda * 0.14;
        }


    }
}
