namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Penalties", "UserId", c => c.Int());
            CreateIndex("dbo.Penalties", "UserId");
            AddForeignKey("dbo.Penalties", "UserId", "dbo.Users", "UserId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Penalties", "UserId", "dbo.Users");
            DropIndex("dbo.Penalties", new[] { "UserId" });
            DropColumn("dbo.Penalties", "UserId");
        }
    }
}
