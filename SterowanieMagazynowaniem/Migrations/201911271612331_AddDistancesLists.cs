namespace SterowanieMagazynowaniem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDistancesLists : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Distances", "Sector_SectorId", c => c.Int());
            AddColumn("dbo.Distances", "Sector_SectorId1", c => c.Int());
            CreateIndex("dbo.Distances", "Sector_SectorId");
            CreateIndex("dbo.Distances", "Sector_SectorId1");
            AddForeignKey("dbo.Distances", "Sector_SectorId", "dbo.Sectors", "SectorId");
            AddForeignKey("dbo.Distances", "Sector_SectorId1", "dbo.Sectors", "SectorId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Distances", "Sector_SectorId1", "dbo.Sectors");
            DropForeignKey("dbo.Distances", "Sector_SectorId", "dbo.Sectors");
            DropIndex("dbo.Distances", new[] { "Sector_SectorId1" });
            DropIndex("dbo.Distances", new[] { "Sector_SectorId" });
            DropColumn("dbo.Distances", "Sector_SectorId1");
            DropColumn("dbo.Distances", "Sector_SectorId");
        }
    }
}
