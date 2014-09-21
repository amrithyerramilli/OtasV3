using System.Data.Entity.Migrations;

namespace OtasV3.Migrations
{
    public partial class UpdateIdentityModelRemoveDbGenerated : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "CreatedAt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "CreatedAt", c => c.DateTime(nullable: false));
        }
    }
}
