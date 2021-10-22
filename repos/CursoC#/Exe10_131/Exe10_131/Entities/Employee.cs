using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe10_131.Entities
{
    public class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {

        }

        public Employee (String nome, int hora, double valorhora)
        {
            Name = nome;
            Hours = hora;
            ValuePerHour = valorhora;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            return Name + " - $ " + Payment().ToString("F2",CultureInfo.InvariantCulture); 
        }


    }
}
