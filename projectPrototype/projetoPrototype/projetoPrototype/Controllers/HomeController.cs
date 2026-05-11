using Microsoft.AspNetCore.Mvc;
using projetoPrototype.Models;
using projetoPrototype.Models.ConcretePrototypes;
using System.Diagnostics;

namespace projetoPrototype.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult TestClone()
        {
            Warrior warrior = new Warrior("Aragorn", 20, "Sword", 80);
            Warrior clonedWarrior = (Warrior)warrior.Clone();

            Mage mage = new Mage("Gandalf", 30, "Staff", 100);
            Mage clonedMage = (Mage)mage.Clone();

            return Content(
                $"Warrior was cloned: {clonedWarrior.Name}, Level: {clonedWarrior.Level}, Weapon: {clonedWarrior.Weapon}, Strength: {clonedWarrior.Strength}" +
                $"Mage was cloned: {clonedMage.Name}, Level: {clonedMage.Level}, Weapon: {clonedMage.Weapon}, Mana: {clonedMage.Mana}"
            );
        }
    }
}
