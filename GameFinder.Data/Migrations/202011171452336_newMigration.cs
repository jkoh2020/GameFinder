namespace GameFinder.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Game", "OwnerId", c => c.Guid(nullable: false));
            AddColumn("dbo.Game", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Game", "Description");
            DropColumn("dbo.Game", "OwnerId");
        }
    }
}
