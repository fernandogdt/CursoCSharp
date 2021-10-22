using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe10_131.Entities
{
    public class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }
        /*
        public OutsourcedEmployee (string nome, int hora, double valorhora, double adicao) 
            : base (nome, hora, valorhora)
        {
            AdditionalCharge = adicao;
        }
        */
        public OutsourcedEmployee(string nome, int hora, double valorhora, double adicao)
        {
            Name = nome;
            Hours = hora;
            ValuePerHour = valorhora;
            AdditionalCharge = adicao;
        }
        
        public override double Payment()
        {
            return base.Payment() + AdditionalCharge * 1.1;

          //  return Hours * ValuePerHour + AdditionalCharge * 1.1;
        }


        



    }
}
