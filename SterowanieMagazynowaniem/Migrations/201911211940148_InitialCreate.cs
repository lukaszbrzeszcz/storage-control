namespace SterowanieMagazynowaniem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Distances",
                c => new
                    {
                        DistanceId = c.Int(nullable: false, identity: true),
                        SectorFromId = c.Int(nullable: false),
                        SectorToId = c.Int(nullable: false),
                        SectorFrom_SectorId = c.Int(),
                        SectorTo_SectorId = c.Int(),
                    })
                .PrimaryKey(t => t.DistanceId)
                .ForeignKey("dbo.Sectors", t => t.SectorFrom_SectorId)
                .ForeignKey("dbo.Sectors", t => t.SectorTo_SectorId)
                .Index(t => t.SectorFrom_SectorId)
                .Index(t => t.SectorTo_SectorId);
            
            CreateTable(
                "dbo.Sectors",
                c => new
                    {
                        SectorId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SectorId);
            
            CreateTable(
                "dbo.Elements",
                c => new
                    {
                        ElementId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        SectorID = c.Int(nullable: false),
                        Order_OrderId = c.Int(),
                    })
                .PrimaryKey(t => t.ElementId)
                .ForeignKey("dbo.Sectors", t => t.SectorID, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.Order_OrderId)
                .Index(t => t.SectorID)
                .Index(t => t.Order_OrderId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Elements", "Order_OrderId", "dbo.Orders");
            DropForeignKey("dbo.Distances", "SectorTo_SectorId", "dbo.Sectors");
            DropForeignKey("dbo.Distances", "SectorFrom_SectorId", "dbo.Sectors");
            DropForeignKey("dbo.Elements", "SectorID", "dbo.Sectors");
            DropIndex("dbo.Elements", new[] { "Order_OrderId" });
            DropIndex("dbo.Elements", new[] { "SectorID" });
            DropIndex("dbo.Distances", new[] { "SectorTo_SectorId" });
            DropIndex("dbo.Distances", new[] { "SectorFrom_SectorId" });
            DropTable("dbo.Orders");
            DropTable("dbo.Elements");
            DropTable("dbo.Sectors");
            DropTable("dbo.Distances");
        }
    }
}
