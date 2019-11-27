namespace SterowanieMagazynowaniem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValueToDistances : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Distances", "Value", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Distances", "Value");
        }
    }
}
