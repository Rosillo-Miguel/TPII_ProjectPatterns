using Microsoft.AspNetCore.Mvc;
using ProjetoAdapter.Adapters.Interfaces;
using  ProjetoAdapter.Adapters;
using ProjetoAdapter.Services;

namespace ProjetoAdapter.Controllers
{
    public class CepController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Buscar(string cep)
        {
            ICepAdapter cepAdapter = new ViaCepAdapter(); 
            //ICepAdapter cepAdapter = new CepExemploAdapter();
            var service = new CepService(cepAdapter);
            var endereco = service.Buscar(cep);
                             
            return View("Index", endereco);
        }
    }
}
