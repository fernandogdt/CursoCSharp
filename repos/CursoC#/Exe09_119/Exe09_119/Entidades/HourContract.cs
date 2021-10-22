using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe09_119.Entidades
{
    public class HourContract
    {
        public DateTime Date { get; private set; }
        public double ValuePerHour { get; private set; }
        public int Hours { get; private set; }


        public HourContract (DateTime data, double valor, int hora)
        {
            Date = data;
            ValuePerHour = valor;
            Hours = hora;
        }

        public double totalValue()
        {
            return ValuePerHour * Hours;
        }

    }
}
