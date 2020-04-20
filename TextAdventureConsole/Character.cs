using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventureConsole
{
    abstract class Character
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public string Species { get; set; }
        public string Origin { get; set; }

        public virtual void DeclarationVirtual(Character character)
        {
            Console.WriteLine($"I am {character.Name} of {character.Origin}!");
        }
    }
}
