using System;
using System.Collections.Generic;

namespace DungeonMasterTools.Models
{
    public class Character
    {
        // Player Information
        public Guid ID { get; set; }
        public string PlayerName { get; set; }
        public string CharacterName { get; set; }
       
        //Attributes
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        //Attribute Scores
        public int StrMod { get; set; }
        public int DexMod { get; set; }
        public int ConMod { get; set; }
        public int IntMod { get; set; }
        public int WisMod { get; set; }
        public int ChaMod { get; set; }


        public int InitiativeScore { get; set; }
        public ICollection<Group> Groups { get; set; }
    }
}