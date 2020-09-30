using System;
using System.Reflection.PortableExecutable;
using ITSUmbria2020.OnlineGame.Library.Models.Characters;

namespace Game1
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Wizard();
            PrintCharacter(new Wizard());
        }
        private static void PrintCharacter(Character character)
        {
            Console.ForegroundColor = (ConsoleColor.Green);
            Console.WriteLine(character.Name);
            Console.ResetColor();
        }
    }
}
