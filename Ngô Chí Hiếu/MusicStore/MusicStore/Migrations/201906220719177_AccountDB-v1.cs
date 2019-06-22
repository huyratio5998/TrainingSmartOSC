namespace MusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountDBv1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 128),
                        Password = c.String(),
                        RememberMe = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.AccountRoles", t => t.UserName)
                .Index(t => t.UserName);
            
            CreateTable(
                "dbo.AccountRoles",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        RoleId = c.Int(nullable: false),
                        RoleName = c.String(),
                        RoleLevel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserName);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accounts", "UserName", "dbo.AccountRoles");
            DropIndex("dbo.Accounts", new[] { "UserName" });
            DropTable("dbo.AccountRoles");
            DropTable("dbo.Accounts");
        }
    }
}
