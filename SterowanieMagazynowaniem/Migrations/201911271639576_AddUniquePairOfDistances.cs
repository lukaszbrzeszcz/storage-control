namespace SterowanieMagazynowaniem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUniquePairOfDistances : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Distances", new[] { "SectorFromId", "SectorToId" }, unique: true, name: "IX_FromAndTo");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Distances", "IX_FromAndTo");
        }
    }
}
