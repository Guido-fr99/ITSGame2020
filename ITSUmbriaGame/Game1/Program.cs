using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using ITSUmbria2020.OnlineGame.Library.Models.Characters;

namespace Game1
{
    class Program
    {
        public static CharacterFactory characterFactory = new CharacterFactory();
        static void Main(string[] args)
        {
            GameManager.Instance().AddPlayers
            (
                characterFactory.Create(CharacterClass.Warrior, "MyName"),
                characterFactory.Create(CharacterClass.Wizard),
                characterFactory.Create()
            );
            GameManager.Instance().PrintPlayers();
        }
    }
}

            
            /*foreach (var character in characters)
            {
                Console.WriteLine($"{character.GetType().Name} Heath = {character.HealthPoints}");
                character.Heal(100);
                Console.WriteLine($"{character.GetType().Name} Heath = {character.HealthPoints}");
            }
        }
    }
}*/