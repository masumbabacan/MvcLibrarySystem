﻿namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bookimage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "BookImage", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "BookImage");
        }
    }
}
