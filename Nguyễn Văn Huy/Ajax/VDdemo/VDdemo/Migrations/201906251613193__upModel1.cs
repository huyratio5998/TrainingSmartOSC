namespace VDdemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _upModel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                        fullname = c.String(),
                        gender = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.Accounts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.Users");
        }
    }
}
