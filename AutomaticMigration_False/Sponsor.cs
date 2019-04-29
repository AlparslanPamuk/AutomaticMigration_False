using System.Collections.Generic;

namespace AutomaticMigration_False
{
    public class Sponsor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Team> Teams { get; set; }
    }
}
