using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventureConsole
{
    class Monster : Character
    {
        public string Attribute { get; set; }
        public string Ability { get; set; }
        public Monster()
        {

        }
        public Monster(string name, int age, double height, string species, string origin, string attribute, string ability)
        {
            Name = name;
            Age = age;
            Height = height;
            Species = species;
            Origin = origin;
            Attribute = attribute;
            Ability = ability;
        }

        public override void DeclarationVirtual(Character character)
        {
            Console.WriteLine($"I am {character.Name}, the {character.Species} of {character.Origin}!");
        }
    }
}
