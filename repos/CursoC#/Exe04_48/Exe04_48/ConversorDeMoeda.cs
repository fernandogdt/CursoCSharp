using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe04_48
{
    class ConversorDeMoeda
    {

        public static double CalculaMoeda(double a, double b)
        {
            return (a * b) + (a * b * 6 / 100.0);
        }


    }
}
