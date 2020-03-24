using System;

namespace DungeonMasterTools.Models
{
    

    public class Group
    {
        public Guid ID { get; set; }
        public Guid GroupID { get; set; }
        public Guid PlayerID { get; set; }
               
        public Character Character { get; set; }
    }
}