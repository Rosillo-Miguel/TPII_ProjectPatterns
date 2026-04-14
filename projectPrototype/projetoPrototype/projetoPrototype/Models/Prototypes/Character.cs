namespace projetoPrototype.Models.Prototypes
{

    // Prototype
    public abstract class Character
    {
        protected Character(string name, int level, string characterClass) { 
            Name = name;
            Level = level;
            CharacterClass = characterClass;
        }
            public string Name { get; set; }
            public int Level { get; set; }
            public string CharacterClass { get; set; }
        public abstract Character Clone();
    }
}
