using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventureConsole
{
    class Warrior : Character
    {
        public bool HasArmor { get; set; }

		private string _weapon;

		public string Weapon
		{
			get { return _weapon; }
			set
			{
				if (string.IsNullOrWhiteSpace(Weapon))
				{
					_weapon = value;
				}
			}
		}
		public Warrior()
		{

		}
		public Warrior(string name, int age, double height, string species, string origin, bool hasArmor, string weapon)
		{
			Name = name;
			Age = age;
			Height = height;
			Species = species;
			Origin = origin;
			HasArmor = hasArmor;
			Weapon = weapon;
		}

		public override void DeclarationVirtual(Character character)
		{
			base.DeclarationVirtual(character);
		}


	}
}
