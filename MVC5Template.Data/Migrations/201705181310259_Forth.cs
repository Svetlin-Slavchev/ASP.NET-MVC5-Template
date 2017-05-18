namespace MVC5Template.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Forth : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TestEFEntities", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.TestEFEntities", "ModifiedOn", c => c.DateTime());
            AddColumn("dbo.TestEFEntityTwoes", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.TestEFEntityTwoes", "ModifiedOn", c => c.DateTime());
            CreateIndex("dbo.TestEFEntities", "IsDeleted");
            CreateIndex("dbo.TestEFEntityTwoes", "IsDeleted");
        }
        
        public override void Down()
        {
            DropIndex("dbo.TestEFEntityTwoes", new[] { "IsDeleted" });
            DropIndex("dbo.TestEFEntities", new[] { "IsDeleted" });
            DropColumn("dbo.TestEFEntityTwoes", "ModifiedOn");
            DropColumn("dbo.TestEFEntityTwoes", "CreatedOn");
            DropColumn("dbo.TestEFEntities", "ModifiedOn");
            DropColumn("dbo.TestEFEntities", "CreatedOn");
        }
    }
}
