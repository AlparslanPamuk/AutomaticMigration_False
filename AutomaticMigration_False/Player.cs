using System;

namespace AutomaticMigration_False
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public Team Team { get; set; }
        public PlayerAdress Adress { get; set; }
    }
}
