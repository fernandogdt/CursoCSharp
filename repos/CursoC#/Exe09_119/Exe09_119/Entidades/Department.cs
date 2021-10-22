using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe09_119.Entidades
{
    public class Department
    {
        public string Name { get; private set; }
        

        public Department (string nome)
        {
            Name = nome;
        }

    }
}
