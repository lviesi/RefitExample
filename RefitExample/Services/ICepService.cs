using Refit;
using RefitExample.Responses;
using System.Threading.Tasks;

namespace RefitExample.Services
{
    public interface ICepService
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAddressAsync(string cep);
    }
}