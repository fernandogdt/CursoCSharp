using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe06_79
{
    class Employee
    {
        public int Id { get; set; }
        string Name { get; set; }
        public double Salary { get; private set;  }

        public Employee (int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }


        public void increasSalary (double percentage)
        {
            Salary = Salary + (Salary * percentage / 100);
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
