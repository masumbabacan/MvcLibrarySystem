namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationadd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "LinkedIn", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "LinkedIn");
        }
    }
}
