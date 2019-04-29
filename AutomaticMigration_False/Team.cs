using System.Collections.Generic;

namespace AutomaticMigration_False
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short Establishment { get; set; }

        public ICollection<Player> Players { get; set; }
        public ICollection<Sponsor> Sponsors { get; set; }
       
    }
}
