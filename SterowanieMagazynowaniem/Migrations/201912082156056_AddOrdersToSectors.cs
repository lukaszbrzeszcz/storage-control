namespace SterowanieMagazynowaniem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrdersToSectors : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Medicines", "Order_OrderId", "dbo.Orders");
            DropIndex("dbo.Medicines", new[] { "Order_OrderId" });
            CreateTable(
                "dbo.OrderMedicines",
                c => new
                    {
                        Order_OrderId = c.Int(nullable: false),
                        Medicine_MedicineId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Order_OrderId, t.Medicine_MedicineId })
                .ForeignKey("dbo.Orders", t => t.Order_OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Medicines", t => t.Medicine_MedicineId, cascadeDelete: true)
                .Index(t => t.Order_OrderId)
                .Index(t => t.Medicine_MedicineId);
            
            DropColumn("dbo.Medicines", "Order_OrderId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Medicines", "Order_OrderId", c => c.Int());
            DropForeignKey("dbo.OrderMedicines", "Medicine_MedicineId", "dbo.Medicines");
            DropForeignKey("dbo.OrderMedicines", "Order_OrderId", "dbo.Orders");
            DropIndex("dbo.OrderMedicines", new[] { "Medicine_MedicineId" });
            DropIndex("dbo.OrderMedicines", new[] { "Order_OrderId" });
            DropTable("dbo.OrderMedicines");
            CreateIndex("dbo.Medicines", "Order_OrderId");
            AddForeignKey("dbo.Medicines", "Order_OrderId", "dbo.Orders", "OrderId");
        }
    }
}
