using Refit;
using System.Threading.Tasks;

namespace VerificaAPI.Entidades
{
    public interface IApiService
    {

        [Get("/brazil/uf/{uf}")]
        Task<APIResponse> GetAddressAsync(string uf);

        /*** chuck ***
        [Get("/random")]
        Task<APIResponse> GetAddressAsync();
        ***/

        /*
        [Get("/advice/{id}")]
        Task<APIResponse> GetAddressAsync(string id);
        */

        /*
                [Get("/ws/{cep}/json")]
                Task<APIResponse> GetAddressAsync(string cep);
        */
    }
}
