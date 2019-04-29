namespace AutomaticMigration_False.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamePopulationToPopulationUpInCountriesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Countries", "PopulationUp", c => c.Int(nullable: false));
            Sql("Update Countries set PopulationUp=Population");
            DropColumn("dbo.Countries", "Population");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Countries", "Population", c => c.Int(nullable: false));
            Sql("Update Countries set Population=PopulationUp");
            DropColumn("dbo.Countries", "PopulationUp");
        }
    }
}
