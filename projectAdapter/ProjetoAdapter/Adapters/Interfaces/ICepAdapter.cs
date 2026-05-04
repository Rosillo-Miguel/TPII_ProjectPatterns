using ProjetoAdapter.Models;
namespace ProjetoAdapter.Adapters.Interfaces
{
    public interface ICepAdapter
    {
        EnderecoModel BuscarCep(string cep);
    }
}
