namespace AutomaticMigration_False.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCountriesTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Teams", "Country_Id", "dbo.Countries");
            DropIndex("dbo.Teams", new[] { "Country_Id" });
            DropColumn("dbo.Teams", "Country_Id");
            CreateTable(
    "dbo._Countries",
    c => new
    {
        Id = c.Int(nullable: false, identity: true),
        Name = c.String(),
    })
    .PrimaryKey(t => t.Id);
            Sql("Insert into _Countries (Name) select Name From Countries");
            DropTable("dbo.Countries");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Teams", "Country_Id", c => c.Int());
            CreateIndex("dbo.Teams", "Country_Id");
            AddForeignKey("dbo.Teams", "Country_Id", "dbo.Countries", "Id");
            DropTable("dbo._Countries");
        }
    }
}
