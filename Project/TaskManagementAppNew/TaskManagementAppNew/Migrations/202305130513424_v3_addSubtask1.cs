namespace TaskManagementAppNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3_addSubtask1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SubTask", "Title", c => c.String());
            DropColumn("dbo.SubTask", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SubTask", "Name", c => c.String());
            DropColumn("dbo.SubTask", "Title");
        }
    }
}
