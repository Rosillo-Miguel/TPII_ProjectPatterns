using System.ComponentModel.Design;
using ProjetoAdapter.Models;
using ProjetoAdapter.Adapters.Interfaces;
namespace ProjetoAdapter.Services
{
    public class CepService
    {
        private readonly ICepAdapter _cepAdapter;

        public CepService(ICepAdapter cepAdapter)
        {
            _cepAdapter = cepAdapter;
        }

        public EnderecoModel Buscar(string cep)
        {
            return _cepAdapter.BuscarCep(cep);
        }
    }
}
