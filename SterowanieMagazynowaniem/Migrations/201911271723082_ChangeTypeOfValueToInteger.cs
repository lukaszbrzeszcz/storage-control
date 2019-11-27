namespace SterowanieMagazynowaniem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTypeOfValueToInteger : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Distances", "Value", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Distances", "Value", c => c.Single(nullable: false));
        }
    }
}
