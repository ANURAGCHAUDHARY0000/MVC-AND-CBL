namespace TaskManagementAppNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2_addtask : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Users", newName: "User");
            CreateTable(
                "dbo.Task",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Discription = c.String(),
                        Title = c.String(),
                        Priority = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        CompletedOn = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Task", "UserId", "dbo.User");
            DropIndex("dbo.Task", new[] { "UserId" });
            DropTable("dbo.Task");
            RenameTable(name: "dbo.User", newName: "Users");
        }
    }
}
