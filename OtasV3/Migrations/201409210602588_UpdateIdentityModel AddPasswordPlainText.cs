using System.Data.Entity.Migrations;

namespace OtasV3.Migrations
{
    public partial class UpdateIdentityModelAddPasswordPlainText : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "PasswordPlainText", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "PasswordPlainText");
        }
    }
}
