using Microsoft.AspNetCore.Mvc;
using projetoPrototype.Models;
using projetoPrototype.Models.ConcretePrototypes;

namespace projetoPrototype.Controllers
{
    public class CharacterController : Controller
    {
        private static CharacterRegistry registry = new CharacterRegistry();

        static CharacterController()
        {
            registry.AddPrototype("warrior", new Warrior("Soldado Base", 10, "Espada", 60));

            registry.AddPrototype("mage", new Mage("Mago Arcano", 15, "Cajado", 120));

            registry.AddPrototype("boss", new Boss("Orc Lord", 50, "Machado", 200, "Earth Smash"));
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Clone(string type)
        {
            var character = registry.CloneCharacter(type);

            character.Name += " Clone";

            return View("Customize", character);
        }
    }
}
