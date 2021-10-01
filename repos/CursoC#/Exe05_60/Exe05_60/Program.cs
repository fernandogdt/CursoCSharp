using System;
using System.Globalization;

namespace Exe05_60
{
    class Program
    {
        static void Main(string[] args)
        {

            int conta;
            string nome;
            char inicial = 'n';
            double valor;
            ContaBancaria cliente;

            Console.Write("Entre o número da conta: ");
            conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            inicial = char.Parse(Console.ReadLine());



            while (inicial != 'n' && inicial != 's')
            {
                Console.Write("Haverá depósito inicial (s/n)? ");
                inicial = char.Parse(Console.ReadLine());
            }


            if (inicial == 'n')
            {
                cliente = new ContaBancaria(conta, nome);
            }
            else
            {
                Console.Write("Entre o valor de deposito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cliente = new ContaBancaria(conta, nome, valor);
            }


            Console.WriteLine("");
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(cliente);

            Console.WriteLine("");
            Console.Write("Entre um valor para depósito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            cliente.Deposito(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cliente);



            Console.WriteLine("");
            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            cliente.Saque(valor);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cliente);
        }
    }
}
