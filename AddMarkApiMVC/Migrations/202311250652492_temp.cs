namespace AddMarkApiMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class temp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        SubjectName = c.String(nullable: false),
                        TotalMark = c.Int(nullable: false),
                        MarkObtained = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SubjectId)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subjects", "StudentId", "dbo.Students");
            DropIndex("dbo.Subjects", new[] { "StudentId" });
            DropTable("dbo.Subjects");
        }
    }
}
