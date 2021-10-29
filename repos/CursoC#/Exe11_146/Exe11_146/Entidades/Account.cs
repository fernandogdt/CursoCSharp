

using Exe11_146.Entidades.Excecoes;

namespace Exe11_146.Entidades
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account (int numero, string titular, double saldo, double limite)
        {
            Number = numero;
            Holder = titular;
            Balance = saldo;
            WithdrawLimit = limite;
        }

        public void Deposit (double amount)
        {
            Balance += amount;
        }


        public void Withdraw (double amount)
        {

            if (amount > WithdrawLimit)
            {
                throw new ValidacaoOperacao("The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new ValidacaoOperacao("Not enough balance");
            }
                

            Balance -= amount;




        }


    }
}
