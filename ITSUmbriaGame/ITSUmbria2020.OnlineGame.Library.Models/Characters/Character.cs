using System;
using System.Collections.Generic;
using System.Text;

namespace ITSUmbria2020.OnlineGame.Library.Models.Characters
{
    public abstract class Character
    {
        public abstract int MaxHealth { get; }

        public string Name { get; set; } = "Player";
        public Gender Gender { get; set; }
        public CharacterType Type { get; set; }
        
    }
    public class Wizard : Character
    {
        public override int MaxHealth => 110;
    }
    public class Rogue : Character
    {
        public override int MaxHealth => 150;
    }
    public class Fighter : Character
    {
        public override int MaxHealth => 200;
    }
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }
    public enum CharacterType
    {
        Human,
        Elf,
        Orc

    }
}
