using ProjetoAdapter.Models;
using ProjetoAdapter.Adapters.Interfaces;   
using System.ComponentModel.Design;
namespace ProjetoAdapter.Adapters
{
    public class CepExemploAdapter : ICepAdapter
    {
        public EnderecoModel BuscarCep(string cep)
        {
            return new EnderecoModel
            {
                Cep = cep,
                Rua = "Endereco Exemplo",
                Bairro = "Bairro Exemplo",
                Cidade = "Cidade Exemplo",
                Estado = "SP"
            };
        }
    }
}
