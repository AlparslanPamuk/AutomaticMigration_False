using System.Data.Entity;

namespace AutomaticMigration_False
{
    public class FootballDbContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerAdress> Adresses { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
    

        public FootballDbContext() : base("FootballDbConStr")
        {

        }
    }
}
