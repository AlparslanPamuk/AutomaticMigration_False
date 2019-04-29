namespace AutomaticMigration_False.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePopulationColumnInCountriesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Countries", "Population", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Countries", "Population");
        }
    }
}
