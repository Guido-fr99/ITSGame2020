using System;
using System.Collections.Generic;
using System.Text;
using ITSUmbria2020.OnlineGame.Library.Models.Characters;


namespace Game1
{
    public class GameManager
    {
        private static GameManager gameManager = null;
        public static GameManager Instance() //=> gameManager ??= new GameManager();
        {
            if (gameManager == null)
            {
                gameManager = GetFromDatabase();
            }
            return gameManager;
        }

        private static GameManager GetFromDatabase()
        {
            return new GameManager();
        }
        public void PrintPlayers()
        {
            foreach (var character in this.Characters)
            {
                character.PrintInfo();
            }
        }

        public List<Character> Characters { get; } = new List<Character>();
        public void AddPlayers(params Character[] character)
        {
            Characters.AddRange(character);
        }

    }
}


