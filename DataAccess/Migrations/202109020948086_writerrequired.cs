namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class writerrequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Writers", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Writers", "LastName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Writers", "LastName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Writers", "FirstName", c => c.String(maxLength: 50));
        }
    }
}
