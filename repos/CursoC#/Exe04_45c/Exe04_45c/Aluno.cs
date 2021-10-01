using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe04_45c
{
    class Aluno
    {
        public string Nome;
        public double n1;
        public double n2;
        public double n3;

        public double NotaFinal()
        {
            return (n1 + n2 + n3);
        }

        public double NotaRestante()
        {
            return (60.0 - NotaFinal());
        }

        public string Situacao()
        {
            if (NotaFinal() >= 60.0)
            {
                return "APROVADO";
            }
            else
            {
               return  "REPROVADO";
            }
        }

    }
}
