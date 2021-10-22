using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe09_123.Entities
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {

        }

        public Client (string nome, string email, DateTime nascimento)
        {
            Name = nome;
            Email = email;
            BirthDate = nascimento;
        }



    }
}
