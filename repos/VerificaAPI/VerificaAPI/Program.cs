using Refit;
using System;
using System.Threading.Tasks;
using VerificaAPI.Entidades;

namespace VerificaAPI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            /*
            var origem = RestService.For<IApiService>("https://api.adviceslip.com");
            Console.Write("id: ");
             string id = Console.ReadLine().ToString();
        
            var resultado = await origem.GetAddressAsync(id);

            Console.WriteLine("Conselho: " + resultado.Advice);
            */

            var origem = RestService.For<IApiService>("https://covid19-brazil-api.now.sh/api/report/v1");
            Console.Write("uf: ");
            string uf = Console.ReadLine().ToString();

            var resultado = await origem.GetAddressAsync(uf);

            Console.WriteLine("Conselho: " + resultado.State + " - " + resultado.Deaths );


            /*** chck **
            var origem = RestService.For<IApiService>("https://api.chucknorris.io/jokes");
            var resultado = await origem.GetAddressAsync();
            Console.WriteLine("Conselho: " + resultado.Value);
            ***/



            /*
            try
            {
                var cepClient = RestService.For<IApiService>("http://viacep.com.br");
                Console.WriteLine("cep:");
                string cep = Console.ReadLine();

                var endereco = await cepClient.GetAddressAsync(cep);

                Console.WriteLine("Logradouro: " + endereco.Logradouro);
            }
            catch (Exception e) {
                Console.WriteLine("Erro");
            }
            */
        }
    }
}
