namespace OtasV3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAdminUserPlainTextPassword : DbMigration
    {
        public override void Up()
        {
            Sql("update AspNetUsers set PasswordPlainText = 'admin@1234' where UserName = 'otasAdmin@rnsit.com'");
        }
        
        public override void Down()
        {
            Sql("update AspNetUsers set PasswordPlainText = NULL where UserName = 'otasAdmin@rnsit.com'");
        }
    }
}
