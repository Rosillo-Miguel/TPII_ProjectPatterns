using projetoPrototype.Models.Prototypes;

namespace projetoPrototype.Models
{
    public class CharacterRegistry
    {
            private Dictionary<string, Character> prototypes = new();

            public void AddPrototype(
                 string key,
                 Character character)
            {
                prototypes[key] = character;
            }

            public Character CloneCharacter(string key)
            {
                return prototypes[key].Clone();
            }
        }
}
