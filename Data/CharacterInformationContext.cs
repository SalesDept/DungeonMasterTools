using DungeonMasterTools.Models;
using Microsoft.EntityFrameworkCore;

namespace DungeonMasterTools.Data
{
    //Creates a new database context named CharacterInformationContext
    public class CharacterInformationContext : DbContext
    {
        public CharacterInformationContext(DbContextOptions<CharacterInformationContext> options) : base(options)
        {
        }

        //This is where we register our models as entities
        public DbSet<Group> Groups { get; set; }
        public DbSet<Character> Characters { get; set; }
    }
}