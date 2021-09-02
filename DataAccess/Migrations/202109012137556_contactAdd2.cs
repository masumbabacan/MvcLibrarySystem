namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contactAdd2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Contacts", "LastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "LastName", c => c.String(maxLength: 50));
        }
    }
}
