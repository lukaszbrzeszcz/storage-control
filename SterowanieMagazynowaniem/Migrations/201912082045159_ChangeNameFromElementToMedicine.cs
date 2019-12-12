namespace SterowanieMagazynowaniem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNameFromElementToMedicine : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Elements", "SectorID", "dbo.Sectors");
            DropForeignKey("dbo.Elements", "Order_OrderId", "dbo.Orders");
            DropIndex("dbo.Elements", new[] { "SectorID" });
            DropIndex("dbo.Elements", new[] { "Order_OrderId" });
            CreateTable(
                "dbo.Medicines",
                c => new
                    {
                        MedicineId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SectorID = c.Int(nullable: false),
                        Order_OrderId = c.Int(),
                    })
                .PrimaryKey(t => t.MedicineId)
                .ForeignKey("dbo.Sectors", t => t.SectorID, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.Order_OrderId)
                .Index(t => t.SectorID)
                .Index(t => t.Order_OrderId);
            
            DropTable("dbo.Elements");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.ElementId);
            
            DropForeignKey("dbo.Medicines", "Order_OrderId", "dbo.Orders");
            DropForeignKey("dbo.Medicines", "SectorID", "dbo.Sectors");
            DropIndex("dbo.Medicines", new[] { "Order_OrderId" });
            DropIndex("dbo.Medicines", new[] { "SectorID" });
            DropTable("dbo.Medicines");
            CreateIndex("dbo.Elements", "Order_OrderId");
            CreateIndex("dbo.Elements", "SectorID");
            AddForeignKey("dbo.Elements", "Order_OrderId", "dbo.Orders", "OrderId");
            AddForeignKey("dbo.Elements", "SectorID", "dbo.Sectors", "SectorId", cascadeDelete: true);
        }
    }
}
