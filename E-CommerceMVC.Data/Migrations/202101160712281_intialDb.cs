﻿namespace E_CommerceMVC.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intialDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
        }
    }
}
