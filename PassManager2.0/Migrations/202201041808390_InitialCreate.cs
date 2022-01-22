namespace PassManager2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Passwords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PTitle = c.String(nullable: false, maxLength: 30),
                        PLogin = c.String(maxLength: 20),
                        PEmail = c.String(maxLength: 30),
                        PURL = c.String(maxLength: 100),
                        PDetails = c.String(maxLength: 100),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LoginName = c.String(nullable: false, maxLength: 30),
                        Name = c.String(maxLength: 20),
                        Surname = c.String(maxLength: 30),
                        Email = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Passwords", "UserId", "dbo.Users");
            DropIndex("dbo.Passwords", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Passwords");
        }
    }
}
