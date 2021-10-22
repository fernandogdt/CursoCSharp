using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exe09_119.Enum;

namespace Exe09_119.Entidades
{
    public class Worker
    {

       public string Name { get; private set; }
       public WorkerLevel Level { get; set; }
       public double BaseSalary { get; set; } 
       public Department Department { get; set; }


        List<HourContract> Contracts { get; set; }  = new List<HourContract>(); 

        public Worker (string nome, WorkerLevel nivel, double baseSal, Department departamento)
        {
            this.Name = nome;
            this.Level = nivel;
            this.BaseSalary = baseSal;
            this.Department = departamento;
        }



       public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        } 

        public void RemoveItem (HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public Double Income(int year, int month)
        {
            double soma = 0;

            foreach (HourContract x in Contracts)
            {

                if (x.Date.Year == year && x.Date.Month == month)
                {
                    soma = soma + x.totalValue();
                }

            }
          
                return BaseSalary + soma;
           
        }

    }
}
