namespace AutomaticMigration_False.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletePopulationUpColumnInCountriesTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Countries", "PopulationUp");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Countries", "PopulationUp", c => c.Int(nullable: false));
        }
    }
}
