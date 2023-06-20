namespace TaskManagementAppNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3_addSubtask : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SubTask",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        CompletedOn = c.DateTime(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                        TaskId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Task", t => t.TaskId, cascadeDelete: true)
                .Index(t => t.TaskId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubTask", "TaskId", "dbo.Task");
            DropIndex("dbo.SubTask", new[] { "TaskId" });
            DropTable("dbo.SubTask");
        }
    }
}
