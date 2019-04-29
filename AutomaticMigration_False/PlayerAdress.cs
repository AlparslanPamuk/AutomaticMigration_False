using System.ComponentModel.DataAnnotations.Schema;

namespace AutomaticMigration_False
{
    public class PlayerAdress
    {
        [ForeignKey("Player")]
        public int PlayerAdressId { get; set; }
        public string City { get; set; }
        public int Street { get; set; }
        public int PostCode { get; set; }

        public Player Player { get; set; }
    }
}
