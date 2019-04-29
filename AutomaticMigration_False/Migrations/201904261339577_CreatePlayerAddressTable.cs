namespace AutomaticMigration_False.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePlayerAddressTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlayerAdresses",
                c => new
                    {
                        PlayerAdressId = c.Int(nullable: false),
                        City = c.String(),
                        Street = c.Int(nullable: false),
                        PostCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PlayerAdressId)
                .ForeignKey("dbo.Players", t => t.PlayerAdressId)
                .Index(t => t.PlayerAdressId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlayerAdresses", "PlayerAdressId", "dbo.Players");
            DropIndex("dbo.PlayerAdresses", new[] { "PlayerAdressId" });
            DropTable("dbo.PlayerAdresses");
        }
    }
}
