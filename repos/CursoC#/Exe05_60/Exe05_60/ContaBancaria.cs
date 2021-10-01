using System;
using System.Globalization;

namespace Exe05_60
{
    class ContaBancaria
    {

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }


        public override string ToString()
        {
            
            return $"Conta {Numero}, Titular: {Titular}, Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

        /*** Construtor 1 ***/
        public ContaBancaria(int conta, string nome)
        {
            Numero = conta;
            Titular = nome;
        }

        /*** Construtor 2 ***/
        public ContaBancaria (int conta, string nome, double valor)
        {
            Numero = conta;
            Titular = nome;
            Deposito(valor);
        }

 
      /*
        public int Numero
        {
            get { return Numero; }
       //   set { Numero = value;  }
        }

        public string Titular
        {
            get { return Titular; }
            set { Titular = value; }
        }

        public double Saldo
        {
            get { return Saldo; }
            set { Saldo = value; }
        }
      */
        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5;
        }


    }
}
