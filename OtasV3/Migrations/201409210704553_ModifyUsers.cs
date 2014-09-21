namespace OtasV3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyUsers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Students", "UpdatedAt", c => c.DateTime());
            AddColumn("dbo.Teachers", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Teachers", "UpdatedAt", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "UpdatedAt");
            DropColumn("dbo.Teachers", "CreatedAt");
            DropColumn("dbo.Students", "UpdatedAt");
            DropColumn("dbo.Students", "CreatedAt");
        }
    }
}
