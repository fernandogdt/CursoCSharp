using System;


namespace Exe06_71
{
    class Inquilino
    {
        public string Nome { get; set; }
        public string Email { get; set; }


        public Inquilino (string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return ": " + Nome + ", " + Email;
        }

    }
}
