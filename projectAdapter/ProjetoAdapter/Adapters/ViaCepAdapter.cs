using ProjetoAdapter.Models;    
using ProjetoAdapter.Adapters.Interfaces;
using System.ComponentModel.Design;
using System.Net.Http;
using System.Text.Json;

namespace ProjetoAdapter.Adapters
{
    public class ViaCepAdapter : ICepAdapter
    {
        public EnderecoModel BuscarCep(string cep)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetStringAsync($"https://viacep.com.br/ws/{cep}/json/").Result;

                var json = JsonDocument.Parse(response).RootElement;

                return new EnderecoModel
                {
                    Cep = json.GetProperty("cep").GetString(),
                    Rua = json.GetProperty("logradouro").GetString(),
                    Bairro = json.GetProperty("bairro").GetString(),
                    Cidade = json.GetProperty("localidade").GetString(),
                    Estado = json.GetProperty("uf").GetString()
                };
            }
        }
    }
}