using projetoPrototype.Models.Prototypes;

namespace projetoPrototype.Models.Entities
{
    // Concrete Prototype
    public class Warrior : Character
    {
        public Warrior(string name, int level, string weapon, int strength) : base(name, level, "Warrior") 
        {
            Weapon = weapon;
            Strength = strength;
        }
        public string Weapon { get; set; }
        public int Strength { get; set; }
        public override Character Clone()
        {
            return (Character)this.MemberwiseClone();
            //return new Warrior(Name, Level, Weapon, Strength);
        }
    }
}
