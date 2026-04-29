using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using projetoPrototype.Models;
using projetoPrototype.Models.ConcretePrototypes;

namespace projetoPrototype.Controllers
{
    public class CharacterController : Controller
    {
        private static CharacterRegistry registry = CreateRegistry();

        private static CharacterRegistry CreateRegistry()
        {

            var registry = new CharacterRegistry();

            registry.AddPrototype("warrior", new Warrior("Soldado Base", 10, "Espada", 60));

            registry.AddPrototype("mage", new Mage("Mago Arcano", 15, "Cajado", 120));

            registry.AddPrototype("boss", new Boss("Orc Lord", 50, "Machado", 200, "Earth Smash"));

            return registry;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Clone(string type)
        {

            var key = type.Trim().ToLowerInvariant();
            ViewData["PrototypeKey"] = key;

            var character = registry.CloneCharacter(key);

            var originalName = character.Name;
            ViewData["OriginalName"] = originalName;
            character.Name += " Clone";

            return View("Customize", character);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(string type, string Name, int Level, string OriginalName)
        {
            var character = registry.CloneCharacter(type);
            ViewData["OriginalName"] = OriginalName;

            character.Name = Name;
            character.Level = Level;

            return View("Result", character);
        }
    }
}
