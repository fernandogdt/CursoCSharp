using System;
using System.Globalization;
namespace Exe04_45c
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.n1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            aluno.n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            aluno.n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(aluno.Situacao());
            
           if (aluno.NotaFinal() < 60.0)
              Console.WriteLine("FALTARAM " + aluno.NotaRestante().ToString("F2",CultureInfo.InvariantCulture) + " PONTOS");

        }
    }
}
