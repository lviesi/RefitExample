using Refit;
using RefitExample.Services;
using System;
using System.Threading.Tasks;

namespace RefitExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var cepClient = RestService.For<ICepService>("https://viacep.com.br");

                Console.WriteLine("Digite o seu CEP:");
                string cep = Console.ReadLine();

                Console.WriteLine($"\nConsultando dados do CEP {cep}...");

                var address = await cepClient.GetAddressAsync(cep);

                Console.Write($"\nLogradouro: {address.Logradouro}" +
                    $"\nBairro: {address.Bairro}" +
                    $"\nLocalidade: {address.Localidade}" +
                    $"\nEstado: {address.Uf}" +
                    $"\nDDD: {address.Ddd}" +
                    $"\nCódigo Ibge: {address.Ibge}");

                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine($"Ocorreu um erro ao consultar seu CEP!");
                Console.ReadKey();
            }            
        }
    }
}