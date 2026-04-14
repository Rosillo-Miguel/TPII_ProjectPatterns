using projetoPrototype.Models.Prototypes;

namespace projetoPrototype.Models.ConcretePrototypes
{
    // Concrete Prototype
    public class Mage : Character
    {
        public Mage(string name, int level, string weapon, int mana) : base(name, level, "Mage")
        {
            Weapon = weapon;
            Mana = mana;
        }
        public string Weapon { get; set; }
        public int Mana { get; set; }
        public override Character Clone()
        {
            return (Character)this.MemberwiseClone();
            //return new Warrior(Name, Level, Weapon, Mana);
        }
    }
}
