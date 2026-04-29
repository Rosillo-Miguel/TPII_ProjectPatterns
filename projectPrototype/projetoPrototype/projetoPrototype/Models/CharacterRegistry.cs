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
            if (key == null)
                throw new Exception("Key veio null");

            if (!prototypes.ContainsKey(key))
                throw new Exception(
                  $"Protótipo {key} não encontrado"
                );

            return prototypes[key].Clone();
        }
    }
}
