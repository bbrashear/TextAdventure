using System;
using System.Collections.Generic;

namespace TextAdventureConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Intro
            Console.WriteLine("Once upon a time, in a land far away, there was a village. This village was a peaceful village " +
                "with many kind hearted townspeople. However, one day the town was visited by an evil, greedy dragon...");

            Monster dragon = new Monster("Drago", 1000, 12, "dragon", "The Dark Mountains", "black", "fire breathing");
            PauseConsole();
            dragon.DeclarationVirtual(dragon);
            PauseConsole();
            Console.WriteLine($"The townspeople cried in terror as {dragon.Name} decimated the town and gathered all the gold" +
                $" and jewels of the town inside the castle.");
            Console.WriteLine("The townspeople fled the town, asking 'Who will save us from this dragon?'");
            PauseConsole();
            Console.WriteLine("The town was left deserted for decades. Eventually, the road to the castle was lost.");
            PauseConsole();
            #endregion

            #region PrepForQuest
            Warrior warrior = new Warrior("Thrandin", 415, 1.9, "elf", "The White Woods", false, "sword");
            warrior.DeclarationVirtual(warrior);
            Console.WriteLine($"*Warrior Description: {warrior.Age} years old, {warrior.Height} meters tall, {warrior.Species}, " +
                $"{warrior.Weapon}*");
            PauseConsole();
            Console.WriteLine($"*{warrior.Name} (you), strangely spawns in the middle of a village... " +
                $"your task is to find another weapon*");
            Console.WriteLine();
            Console.WriteLine("You go to the black smith and he asks: What would you like to buy? A dagger, a bow and arrow, or an ax?");
            Console.WriteLine("*Type the name of the weapon you would like to purchase*");
            Console.WriteLine("Dagger");
            Console.WriteLine("Bow");
            Console.WriteLine("Ax");
            Console.WriteLine();
            string secondWeapon = Console.ReadLine();
            Console.WriteLine(WeaponPurchase(secondWeapon));
            PauseConsole();
            Console.WriteLine("Congrats! You just got your first item. Go ahead and put that in your rucksack.");
            List<string> rucksack = new List<string>();
            AddToRucksack(rucksack, secondWeapon);
            Console.WriteLine();
            CheckRucksack(rucksack);
            PauseConsole();

            Console.WriteLine("For the next couple of days, you explore the village and collect supplies");
            string moneyBag = "money bag";
            AddToRucksack(rucksack, moneyBag);
            string healingPotions = "healing potions"; //basically essentials oils bought from Karen
            AddToRucksack(rucksack, healingPotions);
            string bread = "bread";
            AddToRucksack(rucksack, bread);
            string key = "large iron key";
            AddToRucksack(rucksack, key);
            string ring = "mysteriously inscribed ring";
            AddToRucksack(rucksack, ring);
            Console.WriteLine("*You check what's inside your rucksack before you start your quest*");
            CheckRucksack(rucksack);
            PauseConsole();
            #endregion

            #region Quest
            Console.WriteLine("After days of searching, you come upon the ruins of the old town.");
            Console.WriteLine("You are trying to find the road to the castle amongst the decimated town. The road diverges ahead" +
                " and you must choose either left, right, or straight. Which do you choose?");
            string path = Console.ReadLine();
            PathChoice(path);
            PauseConsole();
            Console.WriteLine("After several miles along the path, you find a hanging lantern with a hatch door beneath it.");
            Console.WriteLine("You open the door to find a treasure chest.");
            PauseConsole();
            Console.WriteLine($"You insert the {key} from your rucksack.");
            PauseConsole();
            Console.WriteLine("It doesn't work so you toss the key aside and just bash open the chest.");
            rucksack.Remove(key);
            PauseConsole();
            Console.WriteLine("Inside the treasure chest you find:");
            string[] treasureChest = new string[4] { "green jewel", "broken crown", "golden spear head", "dirty sock" };
            Console.WriteLine(string.Join(", ", treasureChest));
            PauseConsole();
            Console.WriteLine("As you hold the green jewel up to the light, you see the castle in the distance!");
            Console.WriteLine("You stuff the contents of the treasure chest into your rucksack and take off.");
            rucksack.AddRange(treasureChest);
            PauseConsole();
            #endregion

            #region Ending
            Console.WriteLine();
            Console.WriteLine("When you arrive at the castle, you come to a door with an inscription that says, 'Speak the password and you may enter'.");
            Console.WriteLine("*Type your guess of the password. Hint: it's password*");
            string password;
            do
            {
                password = Console.ReadLine();
                if (password.ToLower() == "password")
                {
                    Console.WriteLine("You may enter");
                }
                else
                {
                    Console.WriteLine("The password is incorrect. Try again.");
                }
            } while (password.ToLower() != "password");

            PauseConsole();

            Console.WriteLine("As you step through the door you look out and see a sea of glittering objects and a large dark shape.");
            Console.WriteLine("You conclude that the shape is the dragon and step closer to investigate. Is it alive?");
            Console.WriteLine();
            Console.WriteLine("*Do you think the dragon is alive? Type yes or no:*");
            string alive = Console.ReadLine().ToLower();
            bool dragonHealth = IsAlive(alive);
            Console.WriteLine();
            Console.WriteLine(GameEnding(dragonHealth));
            #endregion
        }
        public static void PauseConsole()
        {
            Console.WriteLine();
            Console.ReadLine();
        }

        public static string WeaponPurchase(string weapon)
        {
            string dagger = "dagger";
            string bow = "bow and arrow";
            string ax = "ax";

            switch (weapon.ToLower())
            {
                case "dagger":
                    return $"You bought a {dagger}!";
                case "bow":
                    return $"You bought a {bow}!";
                case "ax":
                    return $"You bought an {ax}!";
                default:
                    return "I don't have one of those.";

            }
        }
        public static void AddToRucksack(List<string> rucksack, string item)
        {
            rucksack.Add(item);
        }
        public static void CheckRucksack(List<string> rucksack)
        {
            Console.WriteLine("Here are the items in your rucksack:");
            foreach (string item in rucksack)
            {
                Console.WriteLine(item);
            }
        }
        public static void PathChoice(string path)
        {
            if(path.ToLower() == "left")
            {
                Console.WriteLine("As you walk down the path to the left, it leads you into a dark forest.");
            }
            else if(path.ToLower() == "right")
            {
                Console.WriteLine("As you walk down the path to the right, it leads you into a cold, damp cave.");
            }
            else if(path.ToLower() == "straight")
            {
                Console.WriteLine("As you walk the center path, you begin to climb a dangerous mountain pass.");
            }
            else
            {
                Console.WriteLine("Idk, you turned around to go home??");
            }
        }

        public static bool IsAlive(string alive)
        {
            bool isAlive;
            if(alive == "yes")
            {
                isAlive = true;
            }
            else
            {
                isAlive = false;
            }
            return isAlive;
        }

        public static string GameEnding(bool dragonHealth)
        {
            if(dragonHealth == true)
            {
               return "The dragon is dead! You take all the riches and live happily ever after!";
            }
            else
            {
                return $"The dragon awakens and incinerates you with his fire breath.";
            }
        }
    }
}
