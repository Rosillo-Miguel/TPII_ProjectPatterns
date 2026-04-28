using projetoPrototype.Models.Prototypes;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace projetoPrototype.Models.ConcretePrototypes
{
    public class Boss : Character
    {
        public string Weapon { get; set; }
        public int Strength { get; set; }
        public string SpecialPower { get; set; }

        public Boss(
           string name,
           int level,
           string weapon,
           int strength,
           string specialPower
        ) : base(name, level, "Boss")
        {
            Weapon = weapon;
            Strength = strength;
            SpecialPower = specialPower;
        }

        public override Character Clone()
        {
            return new Boss(
                Name,
                Level,
                Weapon,
                Strength,
                SpecialPower
            );
        }
    }
}
