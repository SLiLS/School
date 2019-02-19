namespace School.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SchoolClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MiddleName = c.String(),
                        SurName = c.String(),
                        Position = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MiddleName = c.String(),
                        SurName = c.String(),
                        Sex = c.String(),
                        ClassId = c.Int(nullable: false),
                        ScoolClass_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SchoolClasses", t => t.ScoolClass_Id)
                .Index(t => t.ScoolClass_Id);
            
            CreateTable(
                "dbo.TeacherSchoolClasses",
                c => new
                    {
                        Teacher_Id = c.Int(nullable: false),
                        SchoolClass_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teacher_Id, t.SchoolClass_Id })
                .ForeignKey("dbo.Teachers", t => t.Teacher_Id, cascadeDelete: true)
                .ForeignKey("dbo.SchoolClasses", t => t.SchoolClass_Id, cascadeDelete: true)
                .Index(t => t.Teacher_Id)
                .Index(t => t.SchoolClass_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "ScoolClass_Id", "dbo.SchoolClasses");
            DropForeignKey("dbo.TeacherSchoolClasses", "SchoolClass_Id", "dbo.SchoolClasses");
            DropForeignKey("dbo.TeacherSchoolClasses", "Teacher_Id", "dbo.Teachers");
            DropIndex("dbo.TeacherSchoolClasses", new[] { "SchoolClass_Id" });
            DropIndex("dbo.TeacherSchoolClasses", new[] { "Teacher_Id" });
            DropIndex("dbo.Students", new[] { "ScoolClass_Id" });
            DropTable("dbo.TeacherSchoolClasses");
            DropTable("dbo.Students");
            DropTable("dbo.Teachers");
            DropTable("dbo.SchoolClasses");
        }
    }
}
