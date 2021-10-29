using System;
using System.Globalization;
using Exe11_146.Entidades;
using Exe11_146.Entidades.Excecoes;

namespace Exe11_146
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                Console.WriteLine("Enter account data");



                Console.Write("Number: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string nome = Console.ReadLine();
                Console.Write("Initial balance: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double limite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account conta = new Account(numero, nome, saldo, limite);

                conta.Withdraw(saque);

                Console.WriteLine("New balance: " + conta.Balance);
            }
            catch (ValidacaoOperacao e)
            {
                Console.WriteLine("Withdraw error: " + e.Message );
            }
            catch (Exception e)
            {
                Console.WriteLine("Vai dar ruim.");
            }
        }
    }
}
